using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyFileUploadResponse.
    /// </summary>
    public class AlipayCommercePropertyFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件所在业务场景下关联的支付宝侧业务ID，与bizScene字段配合使用
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 文件存储系统标识
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 当该字段为空时，系统会尝试获取上传文件的原始文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件访问链接
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
