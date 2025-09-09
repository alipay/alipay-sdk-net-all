using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundCardDepositConsultResponse.
    /// </summary>
    public class AlipayFundCardDepositConsultResponse : AopResponse
    {
        /// <summary>
        /// 凭证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 面额
        /// </summary>
        [XmlElement("denomination")]
        public string Denomination { get; set; }

        /// <summary>
        /// 卡片过期时间
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 制卡单id
        /// </summary>
        [XmlElement("generate_card_order_id")]
        public string GenerateCardOrderId { get; set; }

        /// <summary>
        /// 卡片状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
