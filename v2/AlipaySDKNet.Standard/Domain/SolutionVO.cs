using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SolutionVO Data Structure.
    /// </summary>
    [Serializable]
    public class SolutionVO : AopObject
    {
        /// <summary>
        /// 解决方案实例
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }

        /// <summary>
        /// 解决方案名称
        /// </summary>
        [XmlElement("solution_name")]
        public string SolutionName { get; set; }
    }
}
