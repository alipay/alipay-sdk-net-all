using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterVerifyresultinfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpassporterVerifyresultinfoCreateModel : AopObject
    {
        /// <summary>
        /// 活动code
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 解决方案code
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("verify_issue_config_list")]
        [XmlArrayItem("verify_result_config")]
        public List<VerifyResultConfig> VerifyIssueConfigList { get; set; }
    }
}
