using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCustomerDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RentCustomerDetail : AopObject
    {
        /// <summary>
        /// 支付宝账户OpenId
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝账户UserId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件号的SHA256值
        /// </summary>
        [XmlElement("cert_no_sha_256")]
        public string CertNoSha256 { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 手机号码的SHA256值
        /// </summary>
        [XmlElement("mobile_sha_256")]
        public string MobileSha256 { get; set; }
    }
}
