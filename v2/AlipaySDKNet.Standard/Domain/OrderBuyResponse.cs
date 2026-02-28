using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderBuyResponse Data Structure.
    /// </summary>
    [Serializable]
    public class OrderBuyResponse : AopObject
    {
        /// <summary>
        /// 交易组件订单号。可以把获取到的order_id作为alipay.trade.create（统一收单交易创建接口）extend_params.trade_component_order_id的入参进行关联。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 创单扩展信息
        /// </summary>
        [XmlElement("pay_info_response")]
        public PayInfoResponse PayInfoResponse { get; set; }
    }
}
