using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringOrderPayQueryResponse.
    /// </summary>
    public class KoubeiCateringOrderPayQueryResponse : AopResponse
    {
        /// <summary>
        /// 优惠明细列表
        /// </summary>
        [XmlArray("discount_details")]
        [XmlArrayItem("pos_discount_detail")]
        public List<PosDiscountDetail> DiscountDetails { get; set; }

        /// <summary>
        /// 外部支付订单号,唯一标识本次支付的requestID
        /// </summary>
        [XmlElement("out_pay_no")]
        public string OutPayNo { get; set; }

        /// <summary>
        /// 买家实付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 口碑内部支付订单号,和外部支付订单号一一映射
        /// </summary>
        [XmlElement("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// 买家交易支付成功时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 商家实收金额
        /// </summary>
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 支付结果，INIT-待支付，PROCESS-支付中，PAY-已支付，REFUND-已退款，CLOSE-已关闭
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单付款金额,以元为单位,精确到分
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
