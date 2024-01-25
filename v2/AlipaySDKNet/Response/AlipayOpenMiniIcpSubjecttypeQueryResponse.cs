using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniIcpSubjecttypeQueryResponse.
    /// </summary>
    public class AlipayOpenMiniIcpSubjecttypeQueryResponse : AopResponse
    {
        /// <summary>
        /// 单位性质列表
        /// </summary>
        [XmlArray("subject_types")]
        [XmlArrayItem("icp_subject_type_list")]
        public List<IcpSubjectTypeList> SubjectTypes { get; set; }
    }
}
