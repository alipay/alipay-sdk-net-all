using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderCreateResponse.
    /// </summary>
    public class AlipayOpenMiniOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 建议对客展示文案。当接口返回异常时，建议将当前字段对客进行展示。
        /// </summary>
        [XmlElement("customer_display_text")]
        public string CustomerDisplayText { get; set; }

        /// <summary>
        /// 交易组件订单号。可以把获取到的order_id作为<a href="https://opendocs.alipay.com/mini/05x9kv?scene=de4d6a1e0c6e423b9eefa7c3a6dcb7a5&pathHash=779dc517">alipay.trade.create（统一收单交易创建接口）</a>extend_params.trade_component_order_id的入参进行关联。
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
