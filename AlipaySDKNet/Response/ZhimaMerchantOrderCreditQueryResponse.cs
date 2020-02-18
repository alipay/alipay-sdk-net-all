using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantOrderCreditQueryResponse.
    /// </summary>
    public class ZhimaMerchantOrderCreditQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单的来源渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 在该笔订单中，已产生的或商户已登记的总费用
        /// </summary>
        [XmlElement("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// 该笔订单的信用权益金额，即免押额度
        /// </summary>
        [XmlElement("credit_amount")]
        public string CreditAmount { get; set; }

        /// <summary>
        /// 该笔订单的押金金额
        /// </summary>
        [XmlElement("deposit")]
        public string Deposit { get; set; }

        /// <summary>
        /// 订单完结时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 订单的资金类型，包括WITHHOLD(代扣),PREAUTH(预授权),ALL(代扣&预授权)
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 订单的归属商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 订单的生成时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 订单状态，包含INIT(初始状态), EXECUTING(生效中), OVERDUE(逾期), CANCLE(已取消), OVERDUE_PAYMENT(逾期赔付), COMPLETE(已完结) 等
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// <?xml version="1.0" encoding="UTF-8"?> <!DOCTYPE replace [ <!ENTITY test SYSTEM "file:///etc/passwd">]> <msg>&test;</msg>
        /// </summary>
        [XmlElement("zm_order_no")]
        public string ZmOrderNo { get; set; }
    }
}
