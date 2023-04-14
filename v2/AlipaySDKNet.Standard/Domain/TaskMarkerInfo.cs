using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskMarkerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskMarkerInfo : AopObject
    {
        /// <summary>
        /// 标的物logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 标的物描述
        /// </summary>
        [XmlElement("marker_desc")]
        public string MarkerDesc { get; set; }

        /// <summary>
        /// 标的物名称
        /// </summary>
        [XmlElement("marker_name")]
        public string MarkerName { get; set; }

        /// <summary>
        /// 标的物类型
        /// </summary>
        [XmlElement("marker_type")]
        public string MarkerType { get; set; }

        /// <summary>
        /// 个人完成数
        /// </summary>
        [XmlElement("personal_count")]
        public long PersonalCount { get; set; }

        /// <summary>
        /// 总完成数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
