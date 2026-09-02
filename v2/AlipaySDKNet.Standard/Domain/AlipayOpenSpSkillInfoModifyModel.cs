using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpSkillInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpSkillInfoModifyModel : AopObject
    {
        /// <summary>
        /// SKILL能力编码code
        /// </summary>
        [XmlElement("ability_code")]
        public string AbilityCode { get; set; }

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
        /// 只支持.zip 格式，大小不超过50MB。使用 alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("skill_file")]
        public string SkillFile { get; set; }

        /// <summary>
        /// 支持 PNG、JPG、SVG 格式，大小 ≤ 1MB，建议 1:1，至少 128×128。使用 alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("skill_logo_pic")]
        public string SkillLogoPic { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("support_merchant_type_list")]
        [XmlArrayItem("string")]
        public List<string> SupportMerchantTypeList { get; set; }
    }
}
