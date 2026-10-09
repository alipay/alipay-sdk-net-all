using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelBenefitSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelBenefitSyncModel : AopObject
    {
        /// <summary>
        /// 码值信息
        /// </summary>
        [XmlElement("benefit_code_info")]
        public BenefitCodeInfoDTO BenefitCodeInfo { get; set; }

        /// <summary>
        /// 权益投放信息，比如投放到哪些区域 \哪些店铺 \哪些品牌
        /// </summary>
        [XmlElement("benefit_delivery_info")]
        public BenefitDeliveryInfoDTO BenefitDeliveryInfo { get; set; }

        /// <summary>
        /// 权益展示信息
        /// </summary>
        [XmlElement("benefit_display_info")]
        public BenefitDisplayInfoDTO BenefitDisplayInfo { get; set; }

        /// <summary>
        /// 权益Id，统一权益池中权益的主键id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 包含了权益的总体数量，以及每个用户可以领取的次数限制，参考“附录-BenefitSendRuleDTO”信息
        /// </summary>
        [XmlElement("benefit_send_rule")]
        public BenefitSendRuleDTO BenefitSendRule { get; set; }

        /// <summary>
        /// EXCHANGE_VOUCHER：兑换券；SECRET_VOUCHER：码券；EXTERNAL_MERCHANT_VOUCHER;外部商家券
        /// </summary>
        [XmlElement("benefit_type")]
        public string BenefitType { get; set; }

        /// <summary>
        /// 权益详细内容，包含权益内容和权益的生效时间
        /// </summary>
        [XmlElement("benefit_use_rule")]
        public BenefitUseRuleDTO BenefitUseRule { get; set; }

        /// <summary>
        /// 权益描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 权益领取开始时间，在此时间之后该权益不能被用户领取，ISO8601格式
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [XmlElement("merchant_info")]
        public MerchantInfoDTO MerchantInfo { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 权益来源，一般指权益提供方
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 权益领取开始时间，在此时间之前该权益不能被用户领取，ISO8601格式
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// ONLINE ：上线;PAUSE ：暂停;CLOSE : 关闭;TESTING ： 测试
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
