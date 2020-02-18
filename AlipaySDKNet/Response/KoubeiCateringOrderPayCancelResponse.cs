using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringOrderPayCancelResponse.
    /// </summary>
    public class KoubeiCateringOrderPayCancelResponse : AopResponse
    {
        /// <summary>
        /// 撤销操作:REFUND-退款,CLOSE-关闭
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 外部支付订单号,唯一标识本 次支付的requestID
        /// </summary>
        [XmlElement("out_pay_no")]
        public string OutPayNo { get; set; }

        /// <summary>
        /// 口碑内部支付订单号,和外部支付订单号一一映射
        /// </summary>
        [XmlElement("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
