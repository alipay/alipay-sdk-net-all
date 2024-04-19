using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceFileUploadResponse.
    /// </summary>
    public class AnttechBlockchainFinanceFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 上传成功后返回文件信息
        /// </summary>
        [XmlElement("file_info")]
        public FinanceFileInfo FileInfo { get; set; }
    }
}
