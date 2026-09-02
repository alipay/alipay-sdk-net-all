using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BasicExaminationReport Data Structure.
    /// </summary>
    [Serializable]
    public class BasicExaminationReport : AopObject
    {
        /// <summary>
        /// 项目code
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 项目名称（如"一般检查"）
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_project_list")]
        [XmlArrayItem("basic_physical_item")]
        public List<BasicPhysicalItem> ItemProjectList { get; set; }
    }
}
