using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDecorationFileUploadResponse.
    /// </summary>
    public class AlipayCommerceDecorationFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件所在业务场景下关联的支付宝侧业务ID，与bizScene字段配合使用
        /// </summary>
        [XmlElement("biz_file_id")]
        public string BizFileId { get; set; }

        /// <summary>
        /// 文件key
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件访问URL, 有效期1年
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
