using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyVideocallCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyVideocallCheckModel : AopObject
    {
        /// <summary>
        /// 用于后续访客记录交互
        /// </summary>
        [XmlElement("visit_biz_id")]
        public string VisitBizId { get; set; }
    }
}
