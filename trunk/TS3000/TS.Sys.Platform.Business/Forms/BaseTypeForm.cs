using System;
using System.Collections;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;

namespace TS.Sys.Platform.Business.Forms
{
    public class BaseTypeForm:DefaultForm,IFormEvents
    {
        private BaseInfo _baseInfo;
        private AbstractBaseService _baseService;
        /// <summary>
        /// 初始化Form
        /// 工具栏：toolBtn；
        /// 控件容器：tpControl；
        /// 对象：Info；
        /// 服务：Service；
        /// </summary>
        /// <param name="con"></param>
        public void InitForm(Hashtable con)
        {
            try
            {
                base.InitForm(con);
                info = (BaseInfo)con["Info"];
                _baseInfo = (BaseInfo)con["Info"];
                service = (AbstractBaseService)con["Service"];
                _baseService = (AbstractBaseService)con["Service"];
                this.FormEvents = this;
            }
            catch (Exception e)
            {

            }
        }

        public void New()
        {
             
        }

        public void Delete()
        {
            _baseService.Delete(_baseInfo);
        }

        public void Add()
        {
            _baseService.Add(_baseInfo);
        }

        public void Modify()
        {
            _baseService.Modify(_baseInfo);
        }
    }
}
