using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateInfoDTO : AopObject
    {
        /// <summary>
        /// 支付宝平台侧的凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 支付宝平台侧的凭证核销次序号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 核销状态
        /// </summary>
        [XmlElement("use_status")]
        public string UseStatus { get; set; }

        /// <summary>
        /// 券码code
        /// </summary>
        [XmlElement("voucher_code")]
        public string VoucherCode { get; set; }
    }
}
