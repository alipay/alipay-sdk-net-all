using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketingResultpageQueryResponse.
    /// </summary>
    public class AlipayOfflineMarketingResultpageQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备biztid
        /// </summary>
        [XmlElement("biztid")]
        public string Biztid { get; set; }

        /// <summary>
        /// 结果页内容
        /// </summary>
        [XmlElement("result_page_content")]
        public string ResultPageContent { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 语音文本
        /// </summary>
        [XmlElement("voice_text")]
        public string VoiceText { get; set; }
    }
}
