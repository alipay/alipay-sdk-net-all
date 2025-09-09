using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LmDivisionVO Data Structure.
    /// </summary>
    [Serializable]
    public class LmDivisionVO : AopObject
    {
        /// <summary>
        /// 地区码
        /// </summary>
        [XmlElement("division_code")]
        public long DivisionCode { get; set; }

        /// <summary>
        /// 地区层级
        /// </summary>
        [XmlElement("division_level")]
        public long DivisionLevel { get; set; }

        /// <summary>
        /// 地区名
        /// </summary>
        [XmlElement("division_name")]
        public string DivisionName { get; set; }

        /// <summary>
        /// 父地区码
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }

        /// <summary>
        /// 地区拼音
        /// </summary>
        [XmlElement("pinyin")]
        public string Pinyin { get; set; }
    }
}
