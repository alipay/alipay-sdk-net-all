using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandMembercardOperationQueryResponse.
    /// </summary>
    public class AntMerchantExpandMembercardOperationQueryResponse : AopResponse
    {
        /// <summary>
        /// 最新的卡模版配置
        /// </summary>
        [XmlElement("card_template_config")]
        public MemberCardTemplateConfig CardTemplateConfig { get; set; }

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

        /// <summary>
        /// DRAFT: 草稿待确认 PROCESSING: 流程中 FINISH: 完成
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
