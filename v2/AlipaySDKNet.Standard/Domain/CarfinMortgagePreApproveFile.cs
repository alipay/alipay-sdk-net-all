using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinMortgagePreApproveFile Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinMortgagePreApproveFile : AopObject
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        [XmlElement("file_path")]
        public string FilePath { get; set; }

        /// <summary>
        /// 文件标签
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 传输版本，不同的版本文件位置、加密处理、压缩处理等可能不同。 当前版本为1，后续更新时会进行通知。
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
