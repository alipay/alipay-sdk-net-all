using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateVoucherInfo : AopObject
    {
        /// <summary>
        /// 用户领取的券码code,支付宝商家券活动才会返回券码，其他优惠券活动该值为空
        /// </summary>
        [XmlElement("voucher_code")]
        public string VoucherCode { get; set; }

        /// <summary>
        /// 支付宝券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
