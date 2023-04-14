using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FileInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FileInfo : AopObject
    {
        /// <summary>
        /// 文件类型，唯一值，枚举。  VIDEO=视频; VOICE=语音; PICTURE/JPG/JPEG/PNG=图片; TEXT=文本; DOC, DOCX, XLS, XLSX, PPT, PPTX=MS Office
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 业务素材类型（例如：INTERACTIVE代表交互稿）
        /// </summary>
        [XmlElement("file_biz_type")]
        public string FileBizType { get; set; }

        /// <summary>
        /// 文件地址url,图片大小推荐在10M以内
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 素材外部唯一标识用于风险匹配
        /// </summary>
        [XmlElement("origin_file_id")]
        public string OriginFileId { get; set; }
    }
}
