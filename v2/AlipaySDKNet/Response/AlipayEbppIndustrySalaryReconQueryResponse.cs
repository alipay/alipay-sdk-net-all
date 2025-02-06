using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySalaryReconQueryResponse.
    /// </summary>
    public class AlipayEbppIndustrySalaryReconQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单日期，格式为yyyyMMdd
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 对账文件下载链接(五分钟有效期) String
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 外部交易号。由合作方系统生成，只能包含字母、数字、下划线；需保证合作方系统不重复
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 响应加签xml, base64编码
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }

        /// <summary>
        /// 下载账单类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
