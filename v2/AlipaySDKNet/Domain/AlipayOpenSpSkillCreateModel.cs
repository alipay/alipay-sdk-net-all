using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpSkillCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpSkillCreateModel : AopObject
    {
        /// <summary>
        /// 商户支付宝账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 营业执照号
        /// </summary>
        [XmlElement("business_license_code")]
        public string BusinessLicenseCode { get; set; }

        /// <summary>
        /// 营业执照名称
        /// </summary>
        [XmlElement("business_license_name")]
        public string BusinessLicenseName { get; set; }

        /// <summary>
        /// 商家法人名称
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

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
        /// SKILL英文名称
        /// </summary>
        [XmlElement("skill_english_name")]
        public string SkillEnglishName { get; set; }

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
