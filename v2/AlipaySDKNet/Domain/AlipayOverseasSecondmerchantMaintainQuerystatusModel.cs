using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasSecondmerchantMaintainQuerystatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasSecondmerchantMaintainQuerystatusModel : AopObject
    {
        /// <summary>
        /// 二级商户报备类型，分为ONLINE_PAYMENT和INSTORE_PAYMENT两种
        /// </summary>
        [XmlElement("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// 二级商户ID
        /// </summary>
        [XmlElement("secondary_merchant_id")]
        public string SecondaryMerchantId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
