using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyVideocallCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyVideocallCloseModel : AopObject
    {
        /// <summary>
        /// 用于后续访客记录交互
        /// </summary>
        [XmlElement("visit_biz_id")]
        public string VisitBizId { get; set; }
    }
}
