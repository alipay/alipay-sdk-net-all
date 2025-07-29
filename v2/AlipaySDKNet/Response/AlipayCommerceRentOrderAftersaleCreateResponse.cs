using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentOrderAftersaleCreateResponse.
    /// </summary>
    public class AlipayCommerceRentOrderAftersaleCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝售后单ID
        /// </summary>
        [XmlElement("aftersale_id")]
        public string AftersaleId { get; set; }

        /// <summary>
        /// 商户外部售后单号
        /// </summary>
        [XmlElement("out_aftersale_id")]
        public string OutAftersaleId { get; set; }
    }
}
