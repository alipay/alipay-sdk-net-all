using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandMembercardConfigSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandMembercardConfigSaveModel : AopObject
    {
        /// <summary>
        /// 安心充会员卡面的详细信息
        /// </summary>
        [XmlElement("card_template_config")]
        public MemberCardTemplateConfig CardTemplateConfig { get; set; }

        /// <summary>
        /// 操作会员卡的角色信息，参数设置方式参考：接入指南 的说明
        /// </summary>
        [XmlElement("operator")]
        public MemberCardOperator Operator { get; set; }

        /// <summary>
        /// 外部业务号，幂等判断
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 安心充会员卡核销的范围，可以为空，空就表示能核销商家下面的所有线下店；支持三类规则 1. 特定用户下面的线下店范围，暂时就支持当前商家名下的线下店范围。  2. 当前商家（M4）对应的smid -（暂未开放）  3. 限定特定的商品，如果同时存在，则只判断包含规则。  当前限定了2，就不能生效1的规则。  内部字段都是修改操作，如果字段内容为null，则表示不修改。
        /// </summary>
        [XmlElement("pay_effective_rule")]
        public MemberCardPayEffectiveRule PayEffectiveRule { get; set; }

        /// <summary>
        /// 最大数量为6，安心充储值会有方案列表
        /// </summary>
        [XmlArray("prepaid_promotion_plans")]
        [XmlArrayItem("member_card_create_prepaid_promotion_plan_info")]
        public List<MemberCardCreatePrepaidPromotionPlanInfo> PrepaidPromotionPlans { get; set; }
    }
}
