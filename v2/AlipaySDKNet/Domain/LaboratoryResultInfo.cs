using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LaboratoryResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LaboratoryResultInfo : AopObject
    {
        /// <summary>
        /// 结果提示
        /// </summary>
        [XmlElement("abnormal_type")]
        public string AbnormalType { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 参考值（浓度范围）
        /// </summary>
        [XmlElement("ref_interval")]
        public string RefInterval { get; set; }

        /// <summary>
        /// 检验结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
