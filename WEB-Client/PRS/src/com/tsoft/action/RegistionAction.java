package com.tsoft.action;

import org.apache.struts2.ServletActionContext;
import org.springframework.dao.DataAccessException;

import com.opensymphony.xwork2.ActionSupport;
import com.tsoft.Info.MembersInfo;
import com.tsoft.Info.OperatorInfo;
import com.tsoft.Info.ResultInfo;
import com.tsoft.exception.BusinessException;
import com.tsoft.service.MembersService;
import com.tsoft.service.OperatorService;

public class RegistionAction extends ActionSupport{

	private String username;
	private String password;
	private String id;
	private OperatorService operatorService;
	private MembersService membersService;
	
	public OperatorService getOperatorService() {
		return operatorService;
	}
	public void setOperatorService(OperatorService operatorService) {
		this.operatorService = operatorService;
	}
	public MembersService getMembersService() {
		return membersService;
	}
	public void setMembersService(MembersService membersService) {
		this.membersService = membersService;
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
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	
	public String memReg()
	{
		ResultInfo result = null;
		try
		{
			
			OperatorInfo operInfo = new OperatorInfo();
			operInfo.setId(id);
			operInfo.setPassword(password);
			operInfo.setUsername(username);
			validation(operInfo);
			operatorService.AddOper(operInfo);
			result = new ResultInfo();
			result.setActionUrl("loginForm.action");
			result.setMsgResult("注册成功，请返回登录系统!");
			ServletActionContext.getRequest().setAttribute("resultInfo",result);
			return SUCCESS;
		}
		catch (DataAccessException ex)
		{
			result= new ResultInfo();
			result.setMsgResult("数据连接异常，请联系管理员！");
			ServletActionContext.getRequest().setAttribute("resultInfo",result);
			return ERROR;
		}	
		catch(BusinessException ex)
		{
			result = new ResultInfo();
			result.setMsgResult(ex.getMessage());
			result.setActionUrl("javascript:history.go(-1)");
			ServletActionContext.getRequest().setAttribute("resultInfo",result);
			return ERROR;
		}
	}
	
	/**
	 * 数据校验
	 * @param operInfo
	 * @throws BusinessException
	 */
	private void validation(OperatorInfo operInfo) throws BusinessException {
		validForOperName(operInfo);
		validForOperId(operInfo);
		validForOperIdReg(operInfo);
	}
	
	/**
	 * 校验身份证是否注册
	 * @param result
	 * @param operInfo
	 * @throws BusinessException
	 */
	private void validForOperId(OperatorInfo operInfo) throws BusinessException  {
		MembersInfo mi  = new MembersInfo();
		mi.setcId(operInfo.getId());
		mi= membersService.GetMemberInfo(mi);
		if(mi==null)
		{
			throw new BusinessException("您的身份证还没有在系统登记过，请联系管理员！");			
		}
	}
	
	private void validForOperName(OperatorInfo operInfo) throws BusinessException {
		if(!operatorService.CheckOperatorName(operInfo))
		{
			throw new BusinessException("该用户名已经被注册！");
		}
	}
	
	private void validForOperIdReg(OperatorInfo operInfo) throws BusinessException {
		if(!operatorService.CheckOperatorId(operInfo))
		{
			throw new BusinessException("该身份证已经被注册！");
		}
	}
}
