using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceFixTaskproblemQueryResponse.
    /// </summary>
    public class AlipayCommerceFixTaskproblemQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询到的问题信息列表
        /// </summary>
        [XmlArray("problem_list")]
        [XmlArrayItem("fix_problem_d_t_o")]
        public List<FixProblemDTO> ProblemList { get; set; }
    }
}
