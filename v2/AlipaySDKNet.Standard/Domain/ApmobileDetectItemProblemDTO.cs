using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileDetectItemProblemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileDetectItemProblemDTO : AopObject
    {
        /// <summary>
        /// 检测项子项目
        /// </summary>
        [XmlElement("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 检测项大项目
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 检测子项目检测结果
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
