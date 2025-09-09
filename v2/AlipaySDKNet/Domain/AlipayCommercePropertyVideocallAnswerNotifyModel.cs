using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyVideocallAnswerNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyVideocallAnswerNotifyModel : AopObject
    {
        /// <summary>
        /// 访客流水号
        /// </summary>
        [XmlElement("visit_biz_id")]
        public string VisitBizId { get; set; }
    }
}
