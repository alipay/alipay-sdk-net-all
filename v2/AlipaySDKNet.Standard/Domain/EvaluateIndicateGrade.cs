using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EvaluateIndicateGrade Data Structure.
    /// </summary>
    [Serializable]
    public class EvaluateIndicateGrade : AopObject
    {
        /// <summary>
        /// 得分单位 详见枚举列表
        /// </summary>
        [XmlElement("grade_unit")]
        public string GradeUnit { get; set; }

        /// <summary>
        /// 得分值内容
        /// </summary>
        [XmlElement("grade_value")]
        public string GradeValue { get; set; }

        /// <summary>
        /// 满分值
        /// </summary>
        [XmlElement("perfect_value")]
        public string PerfectValue { get; set; }
    }
}
