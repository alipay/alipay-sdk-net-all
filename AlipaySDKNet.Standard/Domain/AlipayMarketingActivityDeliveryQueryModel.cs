using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityDeliveryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityDeliveryQueryModel : AopObject
    {
        /// <summary>
        /// 当前服务商查询投放的商户信息。 商户自研模式，则该对象可以不填写。 服务商自研模式，则对象中的bussinessType设置为ISV，默认使用当前操作人的信息作为商户信息； 服务商代运营模式，则对象中的bussinessType设置为ISV_FOR_MERCHANT。
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public DeliveryAgencyMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// [已废弃] 待查询的投放配置列表。 最大数量限制20个。
        /// </summary>
        [XmlArray("delivery_config_list")]
        [XmlArrayItem("delivery_config")]
        public List<DeliveryConfig> DeliveryConfigList { get; set; }

        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }
    }
}
