using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LaboratoryProject Data Structure.
    /// </summary>
    [Serializable]
    public class LaboratoryProject : AopObject
    {
        /// <summary>
        /// 异常类型：正常、偏高、偏低、上升、下降等
        /// </summary>
        [XmlElement("abnormal_type")]
        public string AbnormalType { get; set; }

        /// <summary>
        /// 项目名
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 项目结果
        /// </summary>
        [XmlElement("project_result")]
        public string ProjectResult { get; set; }

        /// <summary>
        /// 参考区间
        /// </summary>
        [XmlElement("ref_interval")]
        public string RefInterval { get; set; }

        /// <summary>
        /// 单位。参考区间+单位组合成参考值。
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
