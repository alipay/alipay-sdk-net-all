using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceFileUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件唯一编码
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
