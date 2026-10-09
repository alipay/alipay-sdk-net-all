using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AecpFileDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AecpFileDTO : AopObject
    {
        /// <summary>
        /// 附件大小
        /// </summary>
        [XmlElement("file_size")]
        public long FileSize { get; set; }

        /// <summary>
        /// 资源Id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 附件名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 预览URL
        /// </summary>
        [XmlElement("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        [XmlElement("upload_time")]
        public string UploadTime { get; set; }

        /// <summary>
        /// 上传人
        /// </summary>
        [XmlElement("uploader")]
        public AliEmployeeDTO Uploader { get; set; }

        /// <summary>
        /// url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
