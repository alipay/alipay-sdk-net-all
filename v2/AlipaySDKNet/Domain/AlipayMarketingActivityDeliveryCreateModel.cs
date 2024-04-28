using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityDeliveryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityDeliveryCreateModel : AopObject
    {
        /// <summary>
        /// 服务商代商户创建投放必选。 bussinessType设置为ISV_FOR_MERCHANT。
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public DeliveryAgencyMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 投放计划基础信息。
        /// </summary>
        [XmlElement("delivery_base_info")]
        public DeliveryBaseInfo DeliveryBaseInfo { get; set; }

        /// <summary>
        /// 投放的展位编码。
        /// </summary>
        [XmlElement("delivery_booth_code")]
        public string DeliveryBoothCode { get; set; }

        /// <summary>
        /// [已废弃] 待创建的投放配置列表。 最大数量限制20个。
        /// </summary>
        [XmlArray("delivery_config_list")]
        [XmlArrayItem("delivery_config")]
        public List<DeliveryConfig> DeliveryConfigList { get; set; }

        /// <summary>
        /// 投放计划玩法配置。 限制：投放玩法配置有且仅能配置一个。
        /// </summary>
        [XmlElement("delivery_play_config")]
        public DeliveryPlayConfig DeliveryPlayConfig { get; set; }

        /// <summary>
        /// 投放计划定向规则。
        /// </summary>
        [XmlElement("delivery_target_rule")]
        public DeliveryTargetRule DeliveryTargetRule { get; set; }

        /// <summary>
        /// 商品卖货推广创建幂等号，用作幂等控制。 幂等作用：请求返回与上一次相同的结果。 外部接入方需保证幂等号唯一。
        /// </summary>
        [XmlElement("idem_no")]
        public string IdemNo { get; set; }

        /// <summary>
        /// 商户接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。 幂等作用：请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
