using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TestResult Data Structure.
    /// </summary>
    [Serializable]
    public class TestResult : AopObject
    {
        /// <summary>
        /// 置信区间下界
        /// </summary>
        [XmlElement("c_i_lower")]
        public string CILower { get; set; }

        /// <summary>
        /// 置信区间上界
        /// </summary>
        [XmlElement("c_i_upper")]
        public string CIUpper { get; set; }

        /// <summary>
        /// 差别
        /// </summary>
        [XmlElement("diff")]
        public string Diff { get; set; }

        /// <summary>
        /// p值
        /// </summary>
        [XmlElement("p_val")]
        public string PVal { get; set; }

        /// <summary>
        /// 是否显著
        /// </summary>
        [XmlElement("significance")]
        public bool Significance { get; set; }

        /// <summary>
        /// 指标值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
