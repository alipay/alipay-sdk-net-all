using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelCertificateIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalLargermodelCertificateIdentifyModel : AopObject
    {
        /// <summary>
        /// 出生证明：birth_certificate 户口本：household_register
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 图片Base64编码（与imageUrl二选一）
        /// </summary>
        [XmlElement("image_content")]
        public string ImageContent { get; set; }

        /// <summary>
        /// 图片URL（与imageContent二选一）
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }
    }
}
