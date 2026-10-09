using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandMembercardConfigModifyResponse.
    /// </summary>
    public class AntMerchantExpandMembercardConfigModifyResponse : AopResponse
    {
        /// <summary>
        /// 最新的卡模版配置
        /// </summary>
        [XmlElement("card_template_config")]
        public MemberCardTemplateConfig CardTemplateConfig { get; set; }

        /// <summary>
        /// 商家的安心充配置的唯一编号
        /// </summary>
        [XmlElement("member_product_id")]
        public string MemberProductId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 最新的核销范围
        /// </summary>
        [XmlElement("pay_effective_rule")]
        public MemberCardPayEffectiveRule PayEffectiveRule { get; set; }

        /// <summary>
        /// 最新的优惠方案列表
        /// </summary>
        [XmlArray("prepaid_promotion_plans")]
        [XmlArrayItem("member_card_prepaid_promotion_plan_info")]
        public List<MemberCardPrepaidPromotionPlanInfo> PrepaidPromotionPlans { get; set; }
    }
}
