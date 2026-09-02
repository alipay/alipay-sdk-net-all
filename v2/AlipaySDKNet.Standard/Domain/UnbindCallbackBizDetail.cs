using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnbindCallbackBizDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UnbindCallbackBizDetail : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 取消绑定结果
        /// </summary>
        [XmlElement("unbind_result")]
        public string UnbindResult { get; set; }
    }
}
