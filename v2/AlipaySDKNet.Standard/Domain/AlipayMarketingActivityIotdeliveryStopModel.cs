using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityIotdeliveryStopModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityIotdeliveryStopModel : AopObject
    {
        /// <summary>
        /// 服务商代商户创建投放必选。 bussinessType设置为ISV_FOR_MERCHANT。
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public IotDeliveryAgencyMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }
    }
}
