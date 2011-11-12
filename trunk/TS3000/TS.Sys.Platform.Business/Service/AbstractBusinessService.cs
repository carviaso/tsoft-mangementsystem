using System.Collections;
using TS.Sys.Domain; 
using TS.Sys.Util;
using TS.Sys.Platform.Business.Info;

namespace TS.Sys.Platform.Business.Service
{
    abstract public class AbstractBusinessService:Services
    {  
        
        /// <summary>
        /// 时间戳校验
        /// </summary>
        /// <param name="bmi"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool ValidataForTimeStamp(BusinessMainInfo bmi)
        {
            Hashtable con = new Hashtable();
            con.Add("cTimeStamp",bmi.cTimeStamp);
            ArrayList list = BusinessDao.GetValidatation(con);
            if (list.Count > 0)
            {
                return true;
            }
            {                
                return false;
            } 
        }

        /// <summary>
        /// 审核状态校验,已审核返回true,未审核返回false;
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool ValidataForAudit(BusinessMainInfo bmi)
        {

            ArrayList list = BusinessDao.GetAuditStatus(bmi.cGUID);
            if (list.Count > 0)
            {
                 return false;
            }
            else
            {
                
                return true;
            } 
        }

        public bool ValidataForCodeExists(Result result)
        {
            return true;
        }

        public Result DoDel(BusinessMainInfo bmi)
        {
            Result result = new Result();
            if (!ValidataForTimeStamp(bmi))
            {
                result.Message = SysConst.msgTimeStamp;
                return result; 
            }
            return Del(bmi);
        }

        public Result DoAdd(BusinessMainInfo bmi)
        {
            Result result = new Result();
            if (!ValidataForCodeExists(result))
            {
                result.Message = SysConst.msgAddFaildForCodeExists;
                return result;
            }
            return Add(bmi);
            
        }

        public Result DoModify(BusinessMainInfo bmi)
        {
            Result result = new Result();
            if (!ValidataForTimeStamp(bmi))
            {
                result.Message = SysConst.msgTimeStamp;
                return result;
            }
            return Modify(bmi);
        }

        public Result DoAudit(BusinessMainInfo bmi)
        {
            Result result = new Result();
            if (!ValidataForTimeStamp(bmi))          
            {
                result.Message = SysConst.msgTimeStamp;
                return result;
            }
            if (ValidataForAudit(bmi))
            {
                result.Message = SysConst.msgAudit;
                return result;
            }
            return Audit(bmi);            
        }

        public Result DoUnAudit(BusinessMainInfo bmi)
        {
            Result result = new Result();
            if (!ValidataForTimeStamp(bmi))
            {
                result.Message = SysConst.msgTimeStamp;
                return result;
            }
            if (!ValidataForAudit(bmi))
            {
                result.Message = SysConst.msgUnAudit;
                return result;
            }

            return UnAudit(bmi);
        }

        public ArrayList GetSubResult(object cHeadGUID)
        {
            return BusinessDao.GetSubResult(cHeadGUID);
        }

        abstract public Result Add(BusinessMainInfo bmi);

        abstract public Result Del(BusinessMainInfo bmi);

        abstract public Result Modify(BusinessMainInfo bmi);

        abstract public Result Audit(BusinessMainInfo bmi);

        abstract public Result UnAudit(BusinessMainInfo bmi);

        
      
    }
}
