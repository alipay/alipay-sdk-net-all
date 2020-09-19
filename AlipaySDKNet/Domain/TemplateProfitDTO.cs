using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateProfitDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateProfitDTO : AopObject
    {
        /// <summary>
        /// 利益前缀，如“立减10元”，利益前缀为：立减。随机立减券、减至券不填会使用默认值，其它类型可空。支持自定义动态参数传值，但动态参数需定义为：$_r_profit_pre_desc$。
        /// </summary>
        [XmlElement("profit_pre_desc")]
        public string ProfitPreDesc { get; set; }

        /// <summary>
        /// 利益单位，如“立减10元”，利益单位为：元。除商品券、兑换券可空之外，其它类型不填均有默认值。支持自定义动态参数传值，但动态参数需定义为：$_r_profit_unit$。
        /// </summary>
        [XmlElement("profit_unit")]
        public string ProfitUnit { get; set; }

        /// <summary>
        /// 利益值，如“立减10元”，利益值为：10。与卡券的子类型联动使用。除商品券、随机立减券、兑换券可自定义文案之外，其它类型利益值均限制为数字。支持自定义动态参数传值，但动态参数需定义为：$_r_profit_value$。
        /// </summary>
        [XmlElement("profit_value")]
        public string ProfitValue { get; set; }
    }
}
