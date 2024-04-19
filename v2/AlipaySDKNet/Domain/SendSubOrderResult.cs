using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SendSubOrderResult Data Structure.
    /// </summary>
    [Serializable]
    public class SendSubOrderResult : AopObject
    {
        /// <summary>
        /// 订单有效期，日期类型，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_expire_time")]
        public string OrderExpireTime { get; set; }

        /// <summary>
        /// 组合奖品里面的子订单唯一标识
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
