using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterVerifyresultinfoQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderNpassporterVerifyresultinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("default_verify_issue_info_list")]
        [XmlArrayItem("verify_result_info")]
        public List<VerifyResultInfo> DefaultVerifyIssueInfoList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("recent_verify_issue_info_list")]
        [XmlArrayItem("verify_result_info")]
        public List<VerifyResultInfo> RecentVerifyIssueInfoList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("verify_issue_info_list")]
        [XmlArrayItem("verify_result_info")]
        public List<VerifyResultInfo> VerifyIssueInfoList { get; set; }
    }
}
