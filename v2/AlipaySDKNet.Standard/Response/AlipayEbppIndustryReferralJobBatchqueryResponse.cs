using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryReferralJobBatchqueryResponse.
    /// </summary>
    public class AlipayEbppIndustryReferralJobBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 是否还有下一页
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("job_list")]
        [XmlArrayItem("referral_job_info")]
        public List<ReferralJobInfo> JobList { get; set; }

        /// <summary>
        /// 符合条件的岗位总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
