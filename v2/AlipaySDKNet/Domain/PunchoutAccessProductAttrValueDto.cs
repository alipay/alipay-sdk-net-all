using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PunchoutAccessProductAttrValueDto Data Structure.
    /// </summary>
    [Serializable]
    public class PunchoutAccessProductAttrValueDto : AopObject
    {
        /// <summary>
        /// attr_desc,用于punchout模式产品同步
        /// </summary>
        [XmlElement("attr_desc")]
        public string AttrDesc { get; set; }

        /// <summary>
        /// attr_en_name，用于punchout模式产品同步
        /// </summary>
        [XmlElement("attr_en_name")]
        public string AttrEnName { get; set; }

        /// <summary>
        /// attr_en_value_name_list，用于punchout模式产品同步
        /// </summary>
        [XmlArray("attr_en_value_name_list")]
        [XmlArrayItem("string")]
        public List<string> AttrEnValueNameList { get; set; }

        /// <summary>
        /// attr_name，用于punchout模式产品同步
        /// </summary>
        [XmlElement("attr_name")]
        public string AttrName { get; set; }

        /// <summary>
        /// attr_value_name_list，用于punchout模式产品同步
        /// </summary>
        [XmlArray("attr_value_name_list")]
        [XmlArrayItem("string")]
        public List<string> AttrValueNameList { get; set; }

        /// <summary>
        /// is_key,用于punchout模式产品同步
        /// </summary>
        [XmlElement("is_key")]
        public string IsKey { get; set; }
    }
}
