using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderQueryResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditbizorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 芝麻开通协议号
        /// </summary>
        [XmlElement("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 信用服务订单号
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 信用服务订单状态，区分不同产品： （1）针对产品「先用后付」，涉及状态如下：INIT: 下单状态；TRADE_CLOSED: 订单取消或者交易全额退款； TRADE_FINISHED：扣款成功状态。  （2）针对产品「芝麻风险评估与召回」，状态定义如下： [INIT: 下单状态]；[WAIT_FULFILL：待守约]；[OVERDUE：已逾期]；[TRADE_FINISHED:已守约]； [TRADE_CLOSED：已取消]。
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 信用服务订单金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号。 先用后付产品下必传；芝麻风险评估与召回产品下不传。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 芝麻信用服务ID
        /// </summary>
        [XmlElement("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
