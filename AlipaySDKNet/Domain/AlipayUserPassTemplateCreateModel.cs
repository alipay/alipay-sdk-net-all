using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserPassTemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPassTemplateCreateModel : AopObject
    {
        /// <summary>
        /// 基础属性
        /// </summary>
        [XmlElement("evoucher_info")]
        public TemplateEvoucherDTO EvoucherInfo { get; set; }

        /// <summary>
        /// 文件属性
        /// </summary>
        [XmlElement("file_info")]
        public TemplateFileDTO FileInfo { get; set; }

        /// <summary>
        /// 图片属性
        /// </summary>
        [XmlElement("image")]
        public TemplateImageDTO Image { get; set; }

        /// <summary>
        /// 商户属性
        /// </summary>
        [XmlElement("merchant")]
        public TemplateMerchantDTO Merchant { get; set; }

        /// <summary>
        /// 渠道属性
        /// </summary>
        [XmlElement("platform")]
        public TemplatePlatformDTO Platform { get; set; }

        /// <summary>
        /// 样式属性
        /// </summary>
        [XmlElement("style")]
        public TemplateStyleDTO Style { get; set; }

        /// <summary>
        /// 商户用于控制模版的唯一性（可以使用时间戳保证唯一性）
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
