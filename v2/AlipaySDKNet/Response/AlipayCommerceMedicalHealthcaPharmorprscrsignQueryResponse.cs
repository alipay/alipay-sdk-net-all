using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaPharmorprscrsignQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthcaPharmorprscrsignQueryResponse : AopResponse
    {
        /// <summary>
        /// 药师签名图片的AFTS的fileId（创建药师入驻二维码的时候才会有值）
        /// </summary>
        [XmlElement("sign_name_file_id")]
        public string SignNameFileId { get; set; }

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
        /// 签署状态：SIGNED-签署完成，SIGNING-签署中，REJECTED-拒绝签署（SIGNED签署完成才会其他返回值）
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }
    }
}
