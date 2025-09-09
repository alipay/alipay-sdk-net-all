using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaPrescriptionpicApproveResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthcaPrescriptionpicApproveResponse : AopResponse
    {
        /// <summary>
        /// 加签完成的图片的AFTS的fileId
        /// </summary>
        [XmlElement("sign_pic_file_id")]
        public string SignPicFileId { get; set; }

        /// <summary>
        /// 加签完成的图片的访问链接
        /// </summary>
        [XmlElement("sign_pic_url")]
        public string SignPicUrl { get; set; }
    }
}
