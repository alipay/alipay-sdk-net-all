using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionFileUploadResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 凭证文件唯一标识，由ATFS返回
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
