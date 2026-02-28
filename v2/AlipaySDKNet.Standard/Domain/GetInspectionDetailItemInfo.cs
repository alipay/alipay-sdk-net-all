using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GetInspectionDetailItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GetInspectionDetailItemInfo : AopObject
    {
        /// <summary>
        /// 项目编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 项目类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }
    }
}
