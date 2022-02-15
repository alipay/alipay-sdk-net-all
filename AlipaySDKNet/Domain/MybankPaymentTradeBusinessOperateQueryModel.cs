using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeBusinessOperateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeBusinessOperateQueryModel : AopObject
    {
        /// <summary>
        /// 创建订单时返回的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 操作的请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
