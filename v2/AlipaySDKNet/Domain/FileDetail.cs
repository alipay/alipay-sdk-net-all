using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FileDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FileDetail : AopObject
    {
        /// <summary>
        /// 需要通过alipay.open.file.upload(支付宝文件上传接口)上传文件，获取对应的file_id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 带后缀文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }
    }
}
