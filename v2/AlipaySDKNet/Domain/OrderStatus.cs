using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderStatus Data Structure.
    /// </summary>
    [Serializable]
    public class OrderStatus : AopObject
    {
        /// <summary>
        /// 订单状态信息
        /// </summary>
        [XmlElement("order_code")]
        public string OrderCode { get; set; }

        /// <summary>
        /// 订单状态描述
        /// </summary>
        [XmlElement("order_desc")]
        public string OrderDesc { get; set; }
    }
}
