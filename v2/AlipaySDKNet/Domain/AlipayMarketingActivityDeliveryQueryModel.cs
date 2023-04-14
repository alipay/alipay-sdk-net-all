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
        /// 服务商代商户创建投放必选。 bussinessType设置为ISV_FOR_MERCHANT。
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

        /// <summary>
        /// 商户接入模式  枚举值 SELF_MODE 商户自接入模式 AGENCY_MODE 服务商代接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }
    }
}
