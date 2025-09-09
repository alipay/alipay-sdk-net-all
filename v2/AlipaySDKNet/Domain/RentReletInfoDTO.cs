using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentReletInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentReletInfoDTO : AopObject
    {
        /// <summary>
        /// 原租赁交易组件订单号
        /// </summary>
        [XmlElement("origin_order_id")]
        public string OriginOrderId { get; set; }
    }
}
