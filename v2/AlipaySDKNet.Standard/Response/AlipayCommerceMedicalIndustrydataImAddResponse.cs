using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataImAddResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataImAddResponse : AopResponse
    {
        /// <summary>
        /// 支付宝im会话chatId
        /// </summary>
        [XmlElement("alipay_chat_id")]
        public string AlipayChatId { get; set; }
    }
}
