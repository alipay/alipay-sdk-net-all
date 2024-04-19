using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMallApplyruleDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMallApplyruleDeleteModel : AopObject
    {
        /// <summary>
        /// 商圈商场付多门店业务规则id，调用创建接口返回的值
        /// </summary>
        [XmlElement("biz_rule_id")]
        public string BizRuleId { get; set; }

        /// <summary>
        /// 商圈mallid，由支付宝侧业务提供
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 指定值，由支付宝侧业务提供
        /// </summary>
        [XmlElement("rule_scene")]
        public string RuleScene { get; set; }
    }
}
