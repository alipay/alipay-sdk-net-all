using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainysComplexRefFirst Data Structure.
    /// </summary>
    [Serializable]
    public class RainysComplexRefFirst : AopObject
    {
        /// <summary>
        /// 子参数
        /// </summary>
        [XmlElement("case_string")]
        public string CaseString { get; set; }
    }
}
