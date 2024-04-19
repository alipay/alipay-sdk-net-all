using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityIotdeliveryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityIotdeliveryCreateModel : AopObject
    {
        /// <summary>
        /// 服务商代商户创建投放必选。 bussinessType设置为ISV_FOR_MERCHANT。
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public IotDeliveryAgencyMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 投放计划基础信息
        /// </summary>
        [XmlElement("delivery_base_info")]
        public IotDeliveryBaseInfo DeliveryBaseInfo { get; set; }

        /// <summary>
        /// 展位码，代表券会投放的展位。服务商可根据此字段判断场景，以决定是否要投放券。 可选枚举： BC_ALIPAY_FACE_ACTIVITY_RESULT 刷脸支付后
        /// </summary>
        [XmlElement("delivery_booth_code")]
        public string DeliveryBoothCode { get; set; }

        /// <summary>
        /// 投放计划玩法配置。 限制：投放玩法配置有且仅能配置一个
        /// </summary>
        [XmlElement("delivery_play_config")]
        public IotDeliveryPlayConfig DeliveryPlayConfig { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。 幂等作用：请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
