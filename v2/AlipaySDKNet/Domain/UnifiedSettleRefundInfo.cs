using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnifiedSettleRefundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UnifiedSettleRefundInfo : AopObject
    {
        /// <summary>
        /// 表示退款同步的类型，比如用于标识退款时是否发生垫资
        /// </summary>
        [XmlElement("refund_type")]
        public string RefundType { get; set; }
    }
}
