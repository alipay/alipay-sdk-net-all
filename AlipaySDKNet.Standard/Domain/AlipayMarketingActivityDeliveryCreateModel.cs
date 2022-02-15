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
        /// 当前服务商创建投放的商户信息。 商户自研模式，则该对象可以不填写。 服务商自研模式，则对象中的bussinessType设置为ISV，默认使用当前操作人的信息作为商户信息； 服务商代运营模式，则对象中的bussinessType设置为ISV_FOR_MERCHANT。
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public DeliveryAgencyMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 投放计划基础信息。
        /// </summary>
        [XmlElement("delivery_base_info")]
        public DeliveryBaseInfo DeliveryBaseInfo { get; set; }

        /// <summary>
        /// 投放的展位编码。 枚举值：  PAYMENT_RESULT：本店优惠(支付结果页)。
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
        /// 外部业务单号，用作幂等控制。 幂等作用：请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
