using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AreaDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AreaDTO : AopObject
    {
        /// <summary>
        /// 区域code
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 区域英文名称
        /// </summary>
        [XmlElement("area_english_name")]
        public string AreaEnglishName { get; set; }

        /// <summary>
        /// 区域中文名称
        /// </summary>
        [XmlElement("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 区域拼音名称
        /// </summary>
        [XmlElement("area_pinyin_name")]
        public string AreaPinyinName { get; set; }

        /// <summary>
        /// 区域类型
        /// </summary>
        [XmlElement("area_type")]
        public string AreaType { get; set; }

        /// <summary>
        /// 区域版本信息
        /// </summary>
        [XmlElement("area_version")]
        public long AreaVersion { get; set; }

        /// <summary>
        /// 扩展信息map的格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 区域的父code，若为国家则没有相关信息
        /// </summary>
        [XmlElement("parent_area_code")]
        public string ParentAreaCode { get; set; }
    }
}
