using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnbindQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class UnbindQueryResult : AopObject
    {
        /// <summary>
        /// 取消绑定结果
        /// </summary>
        [XmlElement("cancel_bind_result")]
        public string CancelBindResult { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
