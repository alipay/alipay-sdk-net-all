using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryRecruitJobSyncResponse.
    /// </summary>
    public class AlipayEbppIndustryRecruitJobSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝就业频道岗位id
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 快招岗位id
        /// </summary>
        [XmlElement("recruit_job_id")]
        public string RecruitJobId { get; set; }
    }
}
