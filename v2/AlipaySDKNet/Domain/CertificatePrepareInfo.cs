using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificatePrepareInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CertificatePrepareInfo : AopObject
    {
        /// <summary>
        /// 凭证实例的金额信息，在异常场景下可能为空，需要判断是否有值才可进行使用。
        /// </summary>
        [XmlElement("amount_info")]
        public CertificateInstanceAmountInfo AmountInfo { get; set; }

        /// <summary>
        /// 凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 加密券码，核销接口使用
        /// </summary>
        [XmlElement("encrypted_code")]
        public string EncryptedCode { get; set; }

        /// <summary>
        /// 购买商品的订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("sku_info")]
        public CertificateSkuInfo SkuInfo { get; set; }

        /// <summary>
        /// 商品类型为次卡时该值必填
        /// </summary>
        [XmlElement("times_card_info")]
        public CertificateTimesCardInfo TimesCardInfo { get; set; }

        /// <summary>
        /// 券的有效期开始时间
        /// </summary>
        [XmlElement("valid_begin_time")]
        public string ValidBeginTime { get; set; }

        /// <summary>
        /// 券的有效期结束时间
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }
    }
}
