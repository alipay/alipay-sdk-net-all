using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseTemplateInstanceUploadResponse.
    /// </summary>
    public class AnttechOceanbaseTemplateInstanceUploadResponse : AopResponse
    {
        /// <summary>
        /// 业务主键
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务身份
        /// </summary>
        [XmlElement("biz_key")]
        public string BizKey { get; set; }

        /// <summary>
        /// 根据身份接入申请而来的动态code
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 过期时间，秒
        /// </summary>
        [XmlElement("expires_at")]
        public long ExpiresAt { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 跟渲染类型一样
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 文件下载地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
