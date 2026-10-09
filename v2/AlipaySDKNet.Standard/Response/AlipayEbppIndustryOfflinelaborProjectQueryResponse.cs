using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryOfflinelaborProjectQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryOfflinelaborProjectQueryResponse : AopResponse
    {
        /// <summary>
        /// 页码（从 1 开始）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页面记录（最大 50 ）
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("record_list")]
        [XmlArrayItem("offline_labor_project_job")]
        public List<OfflineLaborProjectJob> RecordList { get; set; }

        /// <summary>
        /// 匹配总记录数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 匹配总页码数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
