using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlegalchainNotaryUploadResponse.
    /// </summary>
    public class AlipayBossProdAntlegalchainNotaryUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件上传返回的fileId，上传失败则无值
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件fileKey,即上传路径，上传失败则无值
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }
    }
}
