using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaSignQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthcaSignQueryResponse : AopResponse
    {
        /// <summary>
        /// 签署完成的PDF的AFTS的fileId
        /// </summary>
        [XmlElement("sign_pdf_file_id")]
        public string SignPdfFileId { get; set; }

        /// <summary>
        /// 签署完成的PDF的访问链接
        /// </summary>
        [XmlElement("sign_pdf_url")]
        public string SignPdfUrl { get; set; }

        /// <summary>
        /// 签署合同状态
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }
    }
}
