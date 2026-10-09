using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenPreOrderBizData Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenPreOrderBizData : AopObject
    {
        /// <summary>
        /// 外部的业务订单
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
