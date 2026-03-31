using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DepositFileList Data Structure.
    /// </summary>
    [Serializable]
    public class DepositFileList : AopObject
    {
        /// <summary>
        /// 文件存证成功后给出的证明文件
        /// </summary>
        [XmlElement("deposit_certify_url")]
        public string DepositCertifyUrl { get; set; }

        /// <summary>
        /// 文件Hash值
        /// </summary>
        [XmlElement("file_hash")]
        public string FileHash { get; set; }

        /// <summary>
        /// 文件的md5值
        /// </summary>
        [XmlElement("file_md_5")]
        public string FileMd5 { get; set; }

        /// <summary>
        /// 存证的文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 链上存证hash
        /// </summary>
        [XmlElement("tx_hash")]
        public string TxHash { get; set; }
    }
}
