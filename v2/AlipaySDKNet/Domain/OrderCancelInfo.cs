using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderCancelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderCancelInfo : AopObject
    {
        /// <summary>
        /// 订单取消操作方
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 订单取消原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
