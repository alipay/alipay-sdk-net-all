using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobOrganizationQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryJobOrganizationQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("job_info_list")]
        [XmlArrayItem("organization_job_info")]
        public List<OrganizationJobInfo> JobInfoList { get; set; }

        /// <summary>
        /// 总岗位数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
