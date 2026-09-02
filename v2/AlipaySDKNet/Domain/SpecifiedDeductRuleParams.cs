using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecifiedDeductRuleParams Data Structure.
    /// </summary>
    [Serializable]
    public class SpecifiedDeductRuleParams : AopObject
    {
        /// <summary>
        /// 用户自定义单月扣款额度，单位元，用于自动充场景下单月最大累计充值金额管控，商户侧传入
        /// </summary>
        [XmlElement("specified_month_limit_amount")]
        public string SpecifiedMonthLimitAmount { get; set; }

        /// <summary>
        /// 签约时指定代扣金额，单位元，传入后后续代扣环节的金额必须等于该金额
        /// </summary>
        [XmlElement("specified_pay_amount")]
        public string SpecifiedPayAmount { get; set; }

        /// <summary>
        /// 扣款条件额度数值，用于自动充场景下低于该额度时触发扣款，商户侧管控
        /// </summary>
        [XmlElement("specified_pay_trigger_amount")]
        public string SpecifiedPayTriggerAmount { get; set; }

        /// <summary>
        /// 元/积分/游戏币
        /// </summary>
        [XmlElement("specified_pay_trigger_unit")]
        public string SpecifiedPayTriggerUnit { get; set; }
    }
}
