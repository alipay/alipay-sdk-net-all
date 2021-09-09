using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandMembercardConfigQueryResponse.
    /// </summary>
    public class AntMerchantExpandMembercardConfigQueryResponse : AopResponse
    {
        /// <summary>
        /// 安心充会员卡面的详细信息
        /// </summary>
        [XmlElement("card_template_config")]
        public MemberCardTemplateConfig CardTemplateConfig { get; set; }

        /// <summary>
        /// 会员产品id
        /// </summary>
        [XmlElement("member_product_id")]
        public string MemberProductId { get; set; }

        /// <summary>
        /// 安心充会员卡核销的范围，可以为空，空就表示能核销商家下面的所有线下店；支持三类规则 1. 特定用户下面的线下店范围，暂时就支持当前商家名下的线下店范围。 2. 当前商家（M4）对应的smid -（暂未开放） 3. 限定特定的商品，如果同时存在，则只判断包含规则。 当前限定了2，就不能生效1的规则。
        /// </summary>
        [XmlElement("pay_effective_rule")]
        public MemberCardPayEffectiveRule PayEffectiveRule { get; set; }

        /// <summary>
        /// 最大数量为5，安心充储值会有方案列表
        /// </summary>
        [XmlArray("prepaid_promotion_plans")]
        [XmlArrayItem("member_card_prepaid_promotion_plan_info")]
        public List<MemberCardPrepaidPromotionPlanInfo> PrepaidPromotionPlans { get; set; }
    }
}
