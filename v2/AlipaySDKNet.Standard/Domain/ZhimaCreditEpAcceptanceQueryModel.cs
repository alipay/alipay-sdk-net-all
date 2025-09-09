using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAcceptanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAcceptanceQueryModel : AopObject
    {
        /// <summary>
        /// 一次信用服务受理的唯一标识。 获取方式：调用受理初始化接口时获取，或订阅商户通知接口时获取
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
