using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySalaryElectronicreceiptQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySalaryElectronicreceiptQueryModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 代发商户的商户号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 申请薪资发放回单、返回的电子回单编号
        /// </summary>
        [XmlElement("receipt_no")]
        public string ReceiptNo { get; set; }

        /// <summary>
        /// 对接收付通加签的xml，通过base64编码
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }
    }
}
