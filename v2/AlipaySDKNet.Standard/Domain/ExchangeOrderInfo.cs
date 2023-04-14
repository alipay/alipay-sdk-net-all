using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExchangeOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExchangeOrderInfo : AopObject
    {
        /// <summary>
        /// 奖品code,唯一标识
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 处理结果描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 处理结果,true:成功，false:失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
