using System.Data;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;

namespace TS.Sys.Platform.BaseData.Service
{
    public class UserService : AbstractBaseService
    {
        private UserDao userDao;

        public UserService()
        {
            userDao = new UserDao();
            base.Daos = userDao;
        }

        public override void Add(BaseInfo baseInfo)
        {
            UserInfo userInfo = (UserInfo)baseInfo;
             userDao.AddUser(userInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            UserInfo userInfo = (UserInfo)baseInfo;
             userDao.ModifyUser(userInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            UserInfo userInfo = (UserInfo)baseInfo;
             userDao.DeleteUser(userInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            UserInfo userInfo = (UserInfo)baseInfo;
             userDao.ForbiddenUser(userInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            UserInfo userInfo = (UserInfo)baseInfo;
             userDao.ValueableUser(userInfo);
        }

        public DataTable QueryForAll()
        {
            return userDao.QueryForAll();
        } 
 
    }
}
