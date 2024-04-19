using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMallApplyruleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMallApplyruleCreateModel : AopObject
    {
        /// <summary>
        /// 商圈mallid，由支付宝侧业务提供
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 规则过期时间内容
        /// </summary>
        [XmlElement("rule_expire_time")]
        public RuleExpireTime RuleExpireTime { get; set; }

        /// <summary>
        /// 规则参数
        /// </summary>
        [XmlElement("rule_limit_params")]
        public RuleLimitCreateParams RuleLimitParams { get; set; }

        /// <summary>
        /// 业务规则名称，便于商户进行区分
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 固定值，由支付宝侧业务提供
        /// </summary>
        [XmlElement("rule_scene")]
        public string RuleScene { get; set; }
    }
}
