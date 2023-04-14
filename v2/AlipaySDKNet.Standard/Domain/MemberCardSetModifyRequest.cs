using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardSetModifyRequest Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardSetModifyRequest : AopObject
    {
        /// <summary>
        /// 期望修改成的卡面信息
        /// </summary>
        [XmlElement("card_template_config")]
        public MemberCardTemplateConfig CardTemplateConfig { get; set; }

        /// <summary>
        /// 商家的安心充配置的唯一编号
        /// </summary>
        [XmlElement("member_product_id")]
        public string MemberProductId { get; set; }

        /// <summary>
        /// 会员卡配置操作员信息，参数设置方式参考：接入指南 的说明
        /// </summary>
        [XmlElement("operator")]
        public MemberCardOperator Operator { get; set; }

        /// <summary>
        /// 安心充会员卡核销的范围，可以为空，空就表示能核销商家下面的所有线下店；支持三类规则 1. 特定用户下面的线下店范围，暂时就支持当前商家名下的线下店范围。 2. 当前商家（M4）对应的smid -（暂未开放） 3. 限定特定的商品，如果同时存在，则只判断包含规则。 当前限定了2，就不能生效1的规则。内部字段如果为null，则表示不修改已有配置。
        /// </summary>
        [XmlElement("pay_effective_rule")]
        public MemberCardPayEffectiveRule PayEffectiveRule { get; set; }

        /// <summary>
        /// 最大数量为6，期望修改成的优惠方案列表： 如果不包含现有的优惠方案对象，则表示期望删除； 如果包含了优惠对象，会校验充送方案是否存在，存在则修改（只支持修改状态），不存在则添加。
        /// </summary>
        [XmlElement("prepaid_promotion_plans")]
        public MemberCardCreatePrepaidPromotionPlanInfo PrepaidPromotionPlans { get; set; }
    }
}
