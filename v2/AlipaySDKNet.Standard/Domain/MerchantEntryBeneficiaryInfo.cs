using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantEntryBeneficiaryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantEntryBeneficiaryInfo : AopObject
    {
        /// <summary>
        /// 受益人的证件有效期，yyyyMMdd。受益人有效期不为长期时，必填。
        /// </summary>
        [XmlElement("beneficiary_cert_expired_date")]
        public string BeneficiaryCertExpiredDate { get; set; }

        /// <summary>
        /// 受益人证件图片在文件存储平台的标识（图片大小小于5M）。图片上传存储平台对应的接口文档 <a href="https://opendocs.alipay.com/open/0alqco?pathHash=87b43f78&scene=common"> ant.merchant.expand.indirect.image.upload</a>
        /// </summary>
        [XmlElement("beneficiary_cert_image")]
        public string BeneficiaryCertImage { get; set; }

        /// <summary>
        /// 受益人证件图片背面在文件存储平台的标识（图片大小小于5M）。图片上传存储平台对应的接口文档 <a href="https://opendocs.alipay.com/open/0alqco?pathHash=87b43f78&scene=common"> ant.merchant.expand.indirect.image.upload</a>
        /// </summary>
        [XmlElement("beneficiary_cert_image_back")]
        public string BeneficiaryCertImageBack { get; set; }

        /// <summary>
        /// 受益人号码
        /// </summary>
        [XmlElement("beneficiary_cert_no")]
        public string BeneficiaryCertNo { get; set; }

        /// <summary>
        /// 受益人证件类型
        /// </summary>
        [XmlElement("beneficiary_cert_type")]
        public string BeneficiaryCertType { get; set; }

        /// <summary>
        /// 受益人名称
        /// </summary>
        [XmlElement("beneficiary_name")]
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// 受益人证件有效期是否为长期有效
        /// </summary>
        [XmlElement("expired_date_is_long_term")]
        public bool ExpiredDateIsLongTerm { get; set; }
    }
}
