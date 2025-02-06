using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySalaryElectronicreceiptApplyResponse.
    /// </summary>
    public class AlipayEbppIndustrySalaryElectronicreceiptApplyResponse : AopResponse
    {
        /// <summary>
        /// 网商商户号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 网商订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求参数中流水号保持一致
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 电子回单编号
        /// </summary>
        [XmlElement("receipt_no")]
        public string ReceiptNo { get; set; }

        /// <summary>
        /// 响应加签xml, base64编码
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }
    }
}
