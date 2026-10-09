using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductionDataSyncRequest Data Structure.
    /// </summary>
    [Serializable]
    public class DeductionDataSyncRequest : AopObject
    {
        /// <summary>
        /// 业务id，唯一键标识
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 核销订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 扣款金额（单位元）
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

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
        /// 扣款调用appId，调用扣款的小程序id
        /// </summary>
        [XmlElement("deduction_invoke_appid")]
        public string DeductionInvokeAppid { get; set; }

        /// <summary>
        /// 扣款单类型
        /// </summary>
        [XmlElement("deduction_order_type")]
        public string DeductionOrderType { get; set; }

        /// <summary>
        /// 扣款计划id，外部传入
        /// </summary>
        [XmlElement("deduction_plan_id")]
        public string DeductionPlanId { get; set; }

        /// <summary>
        /// 扣款状态
        /// </summary>
        [XmlElement("deduction_status")]
        public string DeductionStatus { get; set; }

        /// <summary>
        /// 实际扣款日期
        /// </summary>
        [XmlElement("deduction_time")]
        public string DeductionTime { get; set; }

        /// <summary>
        /// 环境标识，外部传入
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 商户pid，外部传入
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务订单号，外部传入
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 收单主体PID，外部传入
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 扣款计划对应的期数
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 退款金额（单位元）
        /// </summary>
        [XmlElement("refund_price")]
        public string RefundPrice { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 门店id，外部传入
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 间连SMID，外部传入
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 核销订单更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
