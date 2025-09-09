using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAcceptanceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAcceptanceApplyModel : AopObject
    {
        /// <summary>
        /// 一次受理过程的唯一标识，从受理初始化接口获取
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
