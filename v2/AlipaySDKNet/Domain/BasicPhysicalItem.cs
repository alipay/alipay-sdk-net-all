using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BasicPhysicalItem Data Structure.
    /// </summary>
    [Serializable]
    public class BasicPhysicalItem : AopObject
    {
        /// <summary>
        /// 异常类型/结果提示（如"↑"、"↓"、"正常"），异常类型符合医学规范，针对有区间指标有结果展示
        /// </summary>
        [XmlElement("abnormal_type")]
        public string AbnormalType { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        [XmlElement("project_code")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 子项名称（如"身高"）
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 参考区间（如"5.00-10.00"），参考区间符合医学规范
        /// </summary>
        [XmlElement("range")]
        public string Range { get; set; }

        /// <summary>
        /// 结果（如170）
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
