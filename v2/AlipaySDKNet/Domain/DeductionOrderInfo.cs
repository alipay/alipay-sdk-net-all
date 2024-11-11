using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductionOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeductionOrderInfo : AopObject
    {
        /// <summary>
        /// 抽佣信息集合
        /// </summary>
        [XmlArray("bill_fee_info_list")]
        [XmlArrayItem("bill_fee_info")]
        public List<BillFeeInfo> BillFeeInfoList { get; set; }

        /// <summary>
        /// 售卖订单ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 凭证序列号
        /// </summary>
        [XmlElement("certificate_serial")]
        public string CertificateSerial { get; set; }

        /// <summary>
        /// 违约金信息
        /// </summary>
        [XmlElement("damages_info")]
        public DamagesInfo DamagesInfo { get; set; }

        /// <summary>
        /// 扣款金额，单位：分
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 核销现金价值，单位：分
        /// </summary>
        [XmlElement("deduction_cash")]
        public long DeductionCash { get; set; }

        /// <summary>
        /// 核销次数
        /// </summary>
        [XmlElement("deduction_count")]
        public long DeductionCount { get; set; }

        /// <summary>
        /// 扣款失败原因
        /// </summary>
        [XmlElement("deduction_fail_reason")]
        public string DeductionFailReason { get; set; }

        /// <summary>
        /// 扣款失败次数
        /// </summary>
        [XmlElement("deduction_fail_times")]
        public long DeductionFailTimes { get; set; }

        /// <summary>
        /// 核销订单ID
        /// </summary>
        [XmlElement("deduction_order_id")]
        public string DeductionOrderId { get; set; }

        /// <summary>
        /// 每次核销信息
        /// </summary>
        [XmlArray("deduction_order_once_info_list")]
        [XmlArrayItem("deduction_order_once_info")]
        public List<DeductionOrderOnceInfo> DeductionOrderOnceInfoList { get; set; }

        /// <summary>
        /// 核销订单类型
        /// </summary>
        [XmlElement("deduction_order_type")]
        public string DeductionOrderType { get; set; }

        /// <summary>
        /// （1）TIMES_CARD / PERIOD_PAY / AXF_MERCHANT_PERIOD_PAY / AXF_MERCHANT_PERIOD_PAY_INDIRECT：UNPAID、PAYMENT_SUCCESS、PAYMENT_FAILED、REFUND （2）AXF_MONEY_TIME_CARD：FREEZING、FROZEN、UNFREEZING、UNFROZEN、REDEEMING、PAYMENT_FAILED、PAYMENT_SUCCESS、REFUND、PART_REFUND
        /// </summary>
        [XmlElement("deduction_status")]
        public string DeductionStatus { get; set; }

        /// <summary>
        /// 实际扣款时间
        /// </summary>
        [XmlElement("deduction_time")]
        public string DeductionTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务单ID，交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付交易流水号
        /// </summary>
        [XmlElement("payment_no")]
        public string PaymentNo { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 计划扣款时间
        /// </summary>
        [XmlElement("plan_deduction_time")]
        public string PlanDeductionTime { get; set; }

        /// <summary>
        /// 核销方式
        /// </summary>
        [XmlElement("redeem_way")]
        public string RedeemWay { get; set; }

        /// <summary>
        /// 退款金额，单位：分
        /// </summary>
        [XmlElement("refund_cash")]
        public long RefundCash { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 分期单ID
        /// </summary>
        [XmlElement("sub_order_id")]
        public string SubOrderId { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户拒绝原因
        /// </summary>
        [XmlElement("user_refuse_reason")]
        public string UserRefuseReason { get; set; }
    }
}
