using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseQuotacontrolRuleGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseQuotacontrolRuleGetModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }
    }
}
