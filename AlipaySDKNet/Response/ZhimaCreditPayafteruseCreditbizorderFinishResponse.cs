using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderFinishResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditbizorderFinishResponse : AopResponse
    {
        /// <summary>
        /// 信用服务订单号
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 信用服务订单状态.INIT: 下单状态; TRADE_CLOSED: 订单取消或者交易全额退款； TRADE_FINISHED：扣款成功状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商户外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
