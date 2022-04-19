using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskBizDomain Data Structure.
    /// </summary>
    [Serializable]
    public class RiskBizDomain : AopObject
    {
        /// <summary>
        /// 编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 英文名称
        /// </summary>
        [XmlElement("english_name")]
        public string EnglishName { get; set; }

        /// <summary>
        /// 全称
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 名称的拼音，可用于模糊查询
        /// </summary>
        [XmlElement("name_pinyin")]
        public string NamePinyin { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
