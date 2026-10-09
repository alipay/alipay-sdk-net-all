using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySalaryElectronicreceiptQueryResponse.
    /// </summary>
    public class AlipayEbppIndustrySalaryElectronicreceiptQueryResponse : AopResponse
    {
        /// <summary>
        /// 网商商户号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 电子回单CDN下载链接，有时效限制，超时可重新查询
        /// </summary>
        [XmlElement("pdf_download_url")]
        public string PdfDownloadUrl { get; set; }

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

        /// <summary>
        /// 回单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
