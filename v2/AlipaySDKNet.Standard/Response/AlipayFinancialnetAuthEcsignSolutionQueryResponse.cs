using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignSolutionQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignSolutionQueryResponse : AopResponse
    {
        /// <summary>
        /// 解决方案试图对象
        /// </summary>
        [XmlElement("solution_vo")]
        public SolutionOpenVO SolutionVo { get; set; }
    }
}
