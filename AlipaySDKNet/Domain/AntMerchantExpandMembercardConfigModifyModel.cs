using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandMembercardConfigModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandMembercardConfigModifyModel : AopObject
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
        /// 会员卡配置操作员信息
        /// </summary>
        [XmlElement("operator")]
        public MemberCardOperator Operator { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 安心充会员卡核销的范围，可以为空，空就表示能核销商家下面的所有线下店；支持三类规则 1. 特定用户下面的线下店范围，暂时就支持当前商家名下的线下店范围。  2. 当前商家（M4）对应的smid -（暂未开放）  3. 限定特定的商品，如果同时存在，则只判断包含规则。  当前限定了2，就不能生效1的规则。
        /// </summary>
        [XmlElement("pay_effective_rule")]
        public MemberCardPayEffectiveRule PayEffectiveRule { get; set; }

        /// <summary>
        /// 最大数量为5，期望修改成的优惠方案列表： 如果不包含现有的优惠方案对象，则表示期望删除； 如果包含了优惠对象，会校验充送方案是否存在，存在则修改，不存在则添加。
        /// </summary>
        [XmlArray("prepaid_promotion_plans")]
        [XmlArrayItem("member_card_create_prepaid_promotion_plan_info")]
        public List<MemberCardCreatePrepaidPromotionPlanInfo> PrepaidPromotionPlans { get; set; }
    }
}
