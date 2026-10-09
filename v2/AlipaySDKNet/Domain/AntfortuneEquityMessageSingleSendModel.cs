using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneEquityMessageSingleSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneEquityMessageSingleSendModel : AopObject
    {
        /// <summary>
        /// TA编码
        /// </summary>
        [XmlElement("ta_code")]
        public string TaCode { get; set; }

        /// <summary>
        /// 消息模板相关参数，其中包括templateId模板ID和context模板上下文
        /// </summary>
        [XmlElement("template")]
        public MessageTemplate Template { get; set; }

        /// <summary>
        /// 基金交易账号
        /// </summary>
        [XmlElement("trade_account")]
        public string TradeAccount { get; set; }
    }
}
