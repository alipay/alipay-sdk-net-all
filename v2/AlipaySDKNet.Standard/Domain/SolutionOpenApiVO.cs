using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SolutionOpenApiVO Data Structure.
    /// </summary>
    [Serializable]
    public class SolutionOpenApiVO : AopObject
    {
        /// <summary>
        /// 方案code
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }

        /// <summary>
        /// 方案名称
        /// </summary>
        [XmlElement("solution_name")]
        public string SolutionName { get; set; }
    }
}
