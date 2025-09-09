using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单状态： WAIT_PAY：待支付 PAY_COMPLETED：已支付 TRADE_CLOSED：交易关闭
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部医院ID
        /// </summary>
        [XmlElement("out_hospital_id")]
        public string OutHospitalId { get; set; }

        /// <summary>
        /// 外部医院名称
        /// </summary>
        [XmlElement("out_hospital_name")]
        public string OutHospitalName { get; set; }

        /// <summary>
        /// 订单支付时传入的商户订单号。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 因公付金额，单位：元
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付时间 YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 总金额，单位：元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
