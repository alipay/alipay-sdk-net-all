using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthInspectionReport Data Structure.
    /// </summary>
    [Serializable]
    public class HealthInspectionReport : AopObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 临床诊断。前端取这个，影像所见
        /// </summary>
        [XmlElement("dino")]
        public string Dino { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 检查项目
        /// </summary>
        [XmlElement("inspect_project")]
        public string InspectProject { get; set; }

        /// <summary>
        /// 影像地址
        /// </summary>
        [XmlElement("inspect_url")]
        public string InspectUrl { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 报告三级类别
        /// </summary>
        [XmlElement("report_sub_sub_type")]
        public string ReportSubSubType { get; set; }

        /// <summary>
        /// 报告子类别
        /// </summary>
        [XmlElement("report_sub_type")]
        public string ReportSubType { get; set; }

        /// <summary>
        /// 检查结论。前端取这个，诊断意见
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
