using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishRuleDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishRuleDeleteModel : AopObject
    {
        /// <summary>
        /// 菜品规则通用模型
        /// </summary>
        [XmlElement("kb_dish_rule_info")]
        public KbdishRuleInfo KbDishRuleInfo { get; set; }
    }
}
