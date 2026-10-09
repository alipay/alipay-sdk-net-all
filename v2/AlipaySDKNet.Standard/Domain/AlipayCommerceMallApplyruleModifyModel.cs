using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMallApplyruleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMallApplyruleModifyModel : AopObject
    {
        /// <summary>
        /// 商圈门店规则id，规则创建接口执行成功之后返回该值
        /// </summary>
        [XmlElement("biz_rule_id")]
        public string BizRuleId { get; set; }

        /// <summary>
        /// 商圈mallid，由支付宝侧业务提供
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 规则过期时间
        /// </summary>
        [XmlElement("rule_expire_time")]
        public RuleExpireTime RuleExpireTime { get; set; }

        /// <summary>
        /// 规则参数
        /// </summary>
        [XmlElement("rule_limit_params")]
        public RuleLimitModifyParams RuleLimitParams { get; set; }

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
