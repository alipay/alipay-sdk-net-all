using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignedFileInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SignedFileInfoDTO : AopObject
    {
        /// <summary>
        /// 签约后的文件地址
        /// </summary>
        [XmlElement("e_signed_file_key")]
        public string ESignedFileKey { get; set; }

        /// <summary>
        /// 签约原文件地址
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }
    }
}
