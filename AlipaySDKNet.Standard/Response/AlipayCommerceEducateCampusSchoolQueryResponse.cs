using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusSchoolQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusSchoolQueryResponse : AopResponse
    {
        /// <summary>
        /// 学校信息列表
        /// </summary>
        [XmlArray("school_info")]
        [XmlArrayItem("school_info")]
        public List<SchoolInfo> SchoolInfo { get; set; }
    }
}
