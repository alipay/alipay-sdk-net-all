using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateVersionDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateVersionDTO : AopObject
    {
        /// <summary>
        /// 审批流地址
        /// </summary>
        [XmlElement("approve_url")]
        public string ApproveUrl { get; set; }

        /// <summary>
        /// 模板版本描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 编辑地址
        /// </summary>
        [XmlElement("edit_address")]
        public string EditAddress { get; set; }

        /// <summary>
        /// doc格式模板文件地址
        /// </summary>
        [XmlElement("file_address")]
        public string FileAddress { get; set; }

        /// <summary>
        /// 文件名字
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// html格式的模板文件地址
        /// </summary>
        [XmlElement("html_file_address")]
        public string HtmlFileAddress { get; set; }

        /// <summary>
        /// 版本id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// pdf文件地址
        /// </summary>
        [XmlElement("pdf_address")]
        public string PdfAddress { get; set; }

        /// <summary>
        /// pdf格式完整预览链接
        /// </summary>
        [XmlElement("pdf_presigned_url")]
        public string PdfPresignedUrl { get; set; }

        /// <summary>
        /// 预览地址
        /// </summary>
        [XmlElement("preview_address")]
        public string PreviewAddress { get; set; }

        /// <summary>
        /// 完整预览地址
        /// </summary>
        [XmlElement("preview_presigned_url")]
        public string PreviewPresignedUrl { get; set; }

        /// <summary>
        /// 该版本发布时间
        /// </summary>
        [XmlElement("publish_time")]
        public string PublishTime { get; set; }

        /// <summary>
        /// 模板版本状态，有以下取值 DRAFT,IN_APPROVAL,PUBLISHING,PRE,PUBLISH_FAILED,PUBLISHED,OFFLINE
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 模板编码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板库编码
        /// </summary>
        [XmlElement("template_lib_code")]
        public string TemplateLibCode { get; set; }

        /// <summary>
        /// 模板名字
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板版本号
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }

        /// <summary>
        /// 唯一流水号
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
