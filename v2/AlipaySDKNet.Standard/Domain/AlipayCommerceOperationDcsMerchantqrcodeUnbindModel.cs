using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationDcsMerchantqrcodeUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationDcsMerchantqrcodeUnbindModel : AopObject
    {
        /// <summary>
        /// 商户标识
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 联营计划标识
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
