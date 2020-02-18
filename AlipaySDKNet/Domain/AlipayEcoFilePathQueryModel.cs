using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoFilePathQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoFilePathQueryModel : AopObject
    {
        /// <summary>
        /// 先计算文件md5值，在对该md5值进行base64编码
        /// </summary>
        [XmlElement("content_md_5")]
        public string ContentMd5 { get; set; }

        /// <summary>
        /// 目标文件的MIME类型
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 文件名称（必须带上文件扩展名，不然会导致后续发起流程校验过不去 示例：合同.pdf ）
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件大小，单位byte。最大允许上传30Mb
        /// </summary>
        [XmlElement("file_size")]
        public long FileSize { get; set; }
    }
}
