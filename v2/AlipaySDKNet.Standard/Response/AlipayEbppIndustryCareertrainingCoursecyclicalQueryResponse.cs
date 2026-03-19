using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingCoursecyclicalQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingCoursecyclicalQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("class_info_query_v_o")]
        public List<ClassInfoQueryVO> List { get; set; }
    }
}
