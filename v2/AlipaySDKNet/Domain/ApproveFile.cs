using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApproveFile Data Structure.
    /// </summary>
    [Serializable]
    public class ApproveFile : AopObject
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        [XmlElement("file_path")]
        public string FilePath { get; set; }

        /// <summary>
        /// 传输版本，不同的版本文件位置、加密处理、压缩处理等可能不同。
        /// </summary>
        [XmlElement("transfer_version")]
        public string TransferVersion { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
