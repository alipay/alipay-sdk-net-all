using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserPassTemplateQueryResponse.
    /// </summary>
    public class AlipayUserPassTemplateQueryResponse : AopResponse
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
    }
}
