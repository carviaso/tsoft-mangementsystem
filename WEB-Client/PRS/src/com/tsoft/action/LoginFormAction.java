package com.tsoft.action;

import java.util.List;

import org.apache.struts2.ServletActionContext;
import org.springframework.dao.DataAccessException;

import com.opensymphony.xwork2.ActionSupport;
import com.tsoft.Info.MemberAllowInfo;
import com.tsoft.Info.MembersInfo;
import com.tsoft.Info.OperatorInfo;
import com.tsoft.Info.ResultInfo;
import com.tsoft.service.MemberAllowService;
import com.tsoft.service.MembersService;
import com.tsoft.service.OperatorService;

public class LoginFormAction extends ActionSupport {

	private String username;
	private String password;
	private OperatorService operatorService;
	private MembersService membersService;
	private MemberAllowService memberAllowService;

	public MemberAllowService getMemberAllowService() {
		return memberAllowService;
	}

	public void setMemberAllowService(MemberAllowService memberAllowService) {
		this.memberAllowService = memberAllowService;
	}

	public MembersService getMembersService() {
		return membersService;
	}

	public void setMembersService(MembersService membersService) {
		this.membersService = membersService;
	}

	public OperatorService getOperatorService() {
		return operatorService;
	}

	public void setOperatorService(OperatorService operatorService) {
		this.operatorService = operatorService;
	}

	public String logout() {
		ServletActionContext.getRequest().setAttribute("operInfo",null);
		return SUCCESS;
	}

	public String operValidation() {
		try {
			OperatorInfo operInfo = new OperatorInfo();
			operInfo.setPassword(password);
			operInfo.setUsername(username);
			operInfo = operatorService.GetOperatorInfo(operInfo);
			if (operInfo != null) {
				MembersInfo memInfo = new MembersInfo();
				memInfo.setcId(operInfo.getId());
				memInfo = membersService.GetMemberInfo(memInfo);
				List<MemberAllowInfo> memberAllow = memberAllowService
						.getMemberAllow(memInfo);
				ServletActionContext.getRequest().setAttribute("operInfo",
						operInfo);
				ServletActionContext.getRequest().setAttribute("memInfo",memInfo);
				ServletActionContext.getRequest().setAttribute("memAllow",
						memberAllow);
				return SUCCESS;
			} else {
				ResultInfo result = new ResultInfo();
				result.setMsgResult("用户名或密码错误，登录失败！");
				result.setActionUrl("loginForm.action");
				ServletActionContext.getRequest().setAttribute("resultInfo",
						result);
				return ERROR;
			}
		} catch (DataAccessException ex) {
			ResultInfo result = new ResultInfo();
			result.setMsgResult("数据连接异常，请重新登录或者联系管理员！");
			result.setActionUrl("loginForm.action");
			ServletActionContext.getRequest().setAttribute("resultInfo",
					result);
			return ERROR;
		}
	}

	public String getUsername() {
		return username;
	}

	public void setUsername(String username) {
		this.username = username;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}
}
