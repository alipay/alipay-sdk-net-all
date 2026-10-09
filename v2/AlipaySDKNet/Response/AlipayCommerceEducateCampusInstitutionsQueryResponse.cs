using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusInstitutionsQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusInstitutionsQueryResponse : AopResponse
    {
        /// <summary>
        /// 学校简单信息列表
        /// </summary>
        [XmlElement("school_info")]
        public SchoolSimpleInfo SchoolInfo { get; set; }

        /// <summary>
        /// 学校基础信息列表
        /// </summary>
        [XmlArray("school_info_list")]
        [XmlArrayItem("school_base_info")]
        public List<SchoolBaseInfo> SchoolInfoList { get; set; }
    }
}
