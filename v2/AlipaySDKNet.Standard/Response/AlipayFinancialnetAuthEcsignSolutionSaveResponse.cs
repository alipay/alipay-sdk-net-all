using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignSolutionSaveResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignSolutionSaveResponse : AopResponse
    {
        /// <summary>
        /// 解决方案码，唯一值。
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
