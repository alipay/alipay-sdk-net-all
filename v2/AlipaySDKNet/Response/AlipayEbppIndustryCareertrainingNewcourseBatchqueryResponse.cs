using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingNewcourseBatchqueryResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingNewcourseBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("course_query_v_o")]
        public List<CourseQueryVO> List { get; set; }

        /// <summary>
        /// 总数量（个）
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
