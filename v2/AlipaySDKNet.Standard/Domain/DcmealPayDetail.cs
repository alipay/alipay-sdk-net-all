using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DcmealPayDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DcmealPayDetail : AopObject
    {
        /// <summary>
        /// 支付金额，单位元，保留两位小数
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 交易traceId
        /// </summary>
        [XmlElement("trace_no")]
        public string TraceNo { get; set; }

        /// <summary>
        /// 点券/自付
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
