using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpSkillDetailQueryResponse.
    /// </summary>
    public class AlipayOpenSpSkillDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// SKILL能力编码code
        /// </summary>
        [XmlElement("ability_code")]
        public string AbilityCode { get; set; }

        /// <summary>
        /// SKILL能力状态
        /// </summary>
        [XmlElement("ability_status")]
        public string AbilityStatus { get; set; }

        /// <summary>
        /// SKILL能力版本
        /// </summary>
        [XmlElement("ability_version")]
        public string AbilityVersion { get; set; }

        /// <summary>
        /// SKILL中文名称
        /// </summary>
        [XmlElement("skill_chinese_name")]
        public string SkillChineseName { get; set; }

        /// <summary>
        /// SKILL描述
        /// </summary>
        [XmlElement("skill_desc")]
        public string SkillDesc { get; set; }

        /// <summary>
        /// SKILL文件包下载地址
        /// </summary>
        [XmlElement("skill_download_url")]
        public string SkillDownloadUrl { get; set; }

        /// <summary>
        /// SKILL英文名称
        /// </summary>
        [XmlElement("skill_english_name")]
        public string SkillEnglishName { get; set; }

        /// <summary>
        /// SKILL logo URL
        /// </summary>
        [XmlElement("skill_logo_url")]
        public string SkillLogoUrl { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("support_account_type")]
        [XmlArrayItem("string")]
        public List<string> SupportAccountType { get; set; }
    }
}
