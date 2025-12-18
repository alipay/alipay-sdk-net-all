using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityCrowdInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityCrowdInfo : AopObject
    {
        /// <summary>
        /// 人群规则名称
        /// </summary>
        [XmlElement("crowd_rule_name")]
        public string CrowdRuleName { get; set; }

        /// <summary>
        /// 可用的人群类型
        /// </summary>
        [XmlElement("crowd_type")]
        public string CrowdType { get; set; }

        /// <summary>
        /// 限制可用的企业ID列表，为订购了服务商发布的场景服务的企业。
        /// </summary>
        [XmlArray("enterprise_id_list")]
        [XmlArrayItem("string")]
        public List<string> EnterpriseIdList { get; set; }

        /// <summary>
        /// 活动限制人群的类型
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }
    }
}
