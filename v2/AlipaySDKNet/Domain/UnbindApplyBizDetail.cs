using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnbindApplyBizDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UnbindApplyBizDetail : AopObject
    {
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

        /// <summary>
        /// 取消类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
