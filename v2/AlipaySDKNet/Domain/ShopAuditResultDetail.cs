using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopAuditResultDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ShopAuditResultDetail : AopObject
    {
        /// <summary>
        /// 业务类型，比如行业资质类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 结果，通过或者驳回
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
