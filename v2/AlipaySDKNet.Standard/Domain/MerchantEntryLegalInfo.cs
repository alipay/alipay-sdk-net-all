using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantEntryLegalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantEntryLegalInfo : AopObject
    {
        /// <summary>
        /// 法人证件有效期是否为长期有效
        /// </summary>
        [XmlElement("expired_date_is_long_term")]
        public bool ExpiredDateIsLongTerm { get; set; }

        /// <summary>
        /// 法人证件图片在文件存储平台的标识（图片大小小于5M）。图片上传存储平台对应的接口文档 <a href="https://opendocs.alipay.com/open/0alqco?pathHash=87b43f78&scene=common"> ant.merchant.expand.indirect.image.upload</a>
        /// </summary>
        [XmlElement("legal_cert_image")]
        public string LegalCertImage { get; set; }

        /// <summary>
        /// 法人证件图片反面在文件存储平台的标识（图片大小小于5M）。图片上传存储平台对应的接口文档 <a href="https://opendocs.alipay.com/open/0alqco?pathHash=87b43f78&scene=common"> ant.merchant.expand.indirect.image.upload</a>
        /// </summary>
        [XmlElement("legal_cert_image_back")]
        public string LegalCertImageBack { get; set; }

        /// <summary>
        /// 法人证件号码
        /// </summary>
        [XmlElement("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人证件类型
        /// </summary>
        [XmlElement("legal_cert_type")]
        public string LegalCertType { get; set; }

        /// <summary>
        /// 法人的证件有效期，yyyyMMdd。法人有效期不为长期时，必填。
        /// </summary>
        [XmlElement("legal_expired_date")]
        public string LegalExpiredDate { get; set; }

        /// <summary>
        /// 法人名称
        /// </summary>
        [XmlElement("legal_name")]
        public string LegalName { get; set; }
    }
}
