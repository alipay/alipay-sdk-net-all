using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationPromoActivityperiodQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationPromoActivityperiodQueryModel : AopObject
    {
        /// <summary>
        /// 活动唯一编码，固定值
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }
    }
}
