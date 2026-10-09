using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseAntifloodRuleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseAntifloodRuleCreateModel : AopObject
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
        /// IP或IP段
        /// </summary>
        [XmlElement("cidr_block")]
        public string CidrBlock { get; set; }

        /// <summary>
        /// 规则来源  - BARRIER  - BLACKLIST
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
