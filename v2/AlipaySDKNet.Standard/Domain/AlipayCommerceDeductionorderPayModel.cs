using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDeductionorderPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDeductionorderPayModel : AopObject
    {
        /// <summary>
        /// 扣款单id
        /// </summary>
        [XmlElement("deduction_order_id")]
        public string DeductionOrderId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
