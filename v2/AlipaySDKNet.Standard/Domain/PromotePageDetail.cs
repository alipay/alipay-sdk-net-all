using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromotePageDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PromotePageDetail : AopObject
    {
        /// <summary>
        /// 推广页创建时间，格式：yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 推广页id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 推广页名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 推广留资schema
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("promote_page_property")]
        public List<PromotePageProperty> PropertyList { get; set; }

        /// <summary>
        /// 推广页类型：COLLECT_INFO -  普通留资；TRADE - 交易留资
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
