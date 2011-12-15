package com.tsoft.dao;

import java.util.List;
import java.util.Map;

import org.springframework.dao.DataAccessException;
import org.springframework.jdbc.core.support.JdbcDaoSupport;

import com.tsoft.Info.OperatorInfo; 
import com.tsoft.exception.BusinessException;

public class OperatorDao extends JdbcDaoSupport {
 
	public void AddOper(OperatorInfo operInfo) throws DataAccessException,BusinessException
	{
		Object [] params = new Object[]{operInfo.getUsername(),operInfo.getPassword(),operInfo.getId()};
		if(this.getJdbcTemplate().update("insert into PRS_Operator values(?,?,?)",params)<=0)
		{
			throw new BusinessException("ÓÃ»§Ìí¼ÓÊ§°Ü£¡");
		}
			
		
	}
	public OperatorInfo GetOperatorInfo(OperatorInfo operInfo)  throws DataAccessException
	{
		
		List<Map<String,Object>> result = (List<Map<String,Object>>)this.getJdbcTemplate().queryForList("select * from PRS_Operator oper where oper.username =? and oper.password= ?",new Object[]{operInfo.getUsername(),operInfo.getPassword()});
		if(result!=null&&result.size()==0)
		{
			return null;		
		}		
		else
		{
			Map detail = (Map)result.get(0);
			operInfo.setId(detail.get("id").toString());
			operInfo.setPassword(detail.get("password").toString());
			operInfo.setUsername(detail.get("username").toString());
			return operInfo;				
		}
	}
	
	public Boolean CheckOperatorName(OperatorInfo operInfo) throws DataAccessException
	{
		List<Map<String,Object>> result = (List<Map<String,Object>>)this.getJdbcTemplate().queryForList("select 1 from PRS_Operator oper where oper.username =?",new Object[]{operInfo.getUsername()});
		if(result!=null&&result.size()!=0)
		{
			return false;		
		}		
		else
		{
			return true;				
		}
	}
	
	public Boolean CheckOperatorId(OperatorInfo operInfo) throws DataAccessException
	{
		List<Map<String,Object>> result = (List<Map<String,Object>>)this.getJdbcTemplate().queryForList("select 1 from PRS_Operator oper where oper.id =?",new Object[]{operInfo.getId()});
		if(result!=null&&result.size()!=0)
		{
			return false;		
		}		
		else
		{
			return true;				
		}
	}
 
}
