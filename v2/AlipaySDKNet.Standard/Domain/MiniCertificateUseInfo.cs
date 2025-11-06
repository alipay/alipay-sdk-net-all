using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniCertificateUseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniCertificateUseInfo : AopObject
    {
        /// <summary>
        /// 核销金额（元）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 凭证次序号
        /// </summary>
        [XmlElement("certificate_sequence_id")]
        public string CertificateSequenceId { get; set; }

        /// <summary>
        /// 核销门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 核销门店名字
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 核销时间
        /// </summary>
        [XmlElement("use_time")]
        public string UseTime { get; set; }
    }
}
