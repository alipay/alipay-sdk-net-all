using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransCommonQueryResponse.
    /// </summary>
    public class AlipayFundTransCommonQueryResponse : AopResponse
    {
        /// <summary>
        /// 预计到账时间，转账到银行卡专用，格式为yyyy-MM-dd HH:mm:ss，转账受理失败不返回。  注意：  此参数为预计时间，可能与实际到账时间有较大误差，不能作为实际到账时间使用，仅供参考用途。
        /// </summary>
        [XmlElement("arrival_time_end")]
        public string ArrivalTimeEnd { get; set; }

        /// <summary>
        /// 商户查询代扣订单信息时返回其在代扣请求中传入的账单属性
        /// </summary>
        [XmlElement("deduct_bill_info")]
        public string DeductBillInfo { get; set; }

        /// <summary>
        /// 查询到的订单状态为FAIL失败或REFUND退票时，返回错误代码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 查询到的订单状态为FAIL失败时，返回具体报错银行的错误码。
        /// </summary>
        [XmlElement("fail_inst_error_code")]
        public string FailInstErrorCode { get; set; }

        /// <summary>
        /// 查询到的订单状态为FAIL失败时，返回具体的报错银行名称
        /// </summary>
        [XmlElement("fail_inst_name")]
        public string FailInstName { get; set; }

        /// <summary>
        /// 查询到的订单状态为FAIL失败时，返回具体的原因。
        /// </summary>
        [XmlElement("fail_inst_reason")]
        public string FailInstReason { get; set; }

        /// <summary>
        /// 查询到的订单状态为FAIL失败或REFUND退票时，返回具体的原因。
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 金融机构发起签约类、支付类、差错类业务时，应为每笔业务分配唯一的交易流水号。31位交易流水号组成规则为：“8位日期”+“16位序列号”+“1位预留位”+“6位控制位”，其中： a）“8位日期”为系统当前日期，ISODate格式：“YYYYMMDD” b）“16位序列号”由金融机构生成，金融机构应确保该值在网联当日唯一 c）“1位预留位”由平台分配 d）“6位控制位”由金融机构通过平台获取 例如：2023052993044491260542090100400
        /// </summary>
        [XmlElement("inflow_settle_serial_no")]
        public string InflowSettleSerialNo { get; set; }

        /// <summary>
        /// 预计收费金额（元），转账到银行卡专用，数字格式，精确到小数点后2位，转账失败或转账受理失败不返回。
        /// </summary>
        [XmlElement("order_fee")]
        public string OrderFee { get; set; }

        /// <summary>
        /// 支付宝转账单据号，查询失败不返回。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户回传参数
        /// </summary>
        [XmlElement("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 支付时间，格式为yyyy-MM-dd HH:mm:ss，转账失败不返回。
        /// </summary>
        [XmlElement("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 支付宝支付资金流水号，转账失败不返回。
        /// </summary>
        [XmlElement("pay_fund_order_id")]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// 收款方支付宝账号openid
        /// </summary>
        [XmlElement("receiver_open_id")]
        public string ReceiverOpenId { get; set; }

        /// <summary>
        /// 收款方支付宝账号uid
        /// </summary>
        [XmlElement("receiver_user_id")]
        public string ReceiverUserId { get; set; }

        /// <summary>
        /// 金融机构发起签约类、支付类、差错类业务时，应为每笔业务分配唯一的交易流水号。31位交易流水号组成规则为：“8位日期”+“16位序列号”+“1位预留位”+“6位控制位”，其中： a）“8位日期”为系统当前日期，ISODate格式：“YYYYMMDD” b）“16位序列号”由金融机构生成，金融机构应确保该值在网联当日唯一 c）“1位预留位”由平台分配 d）“6位控制位”由金融机构通过平台获取 例如：2023052993044491260542090100400
        /// </summary>
        [XmlElement("settle_serial_no")]
        public string SettleSerialNo { get; set; }

        /// <summary>
        /// 转账单据状态。可能出现的状态如下： SUCCESS：转账成功； WAIT_PAY：等待支付； CLOSED：订单超时关闭； FAIL：失败（适用于"单笔转账到银行卡"）； DEALING：处理中（适用于"单笔转账到银行卡"）； REFUND：退票（适用于"单笔转账到银行卡"）； alipay.fund.trans.app.pay涉及的状态： WAIT_PAY、SUCCESS、CLOSED alipay.fund.trans.refund涉及的状态：SUCCESS alipay.fund.trans.uni.transfer涉及的状态：SUCCESS、FAIL、DEALING、REFUND
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 特殊场景提供，当子单出现异常导致主单失败或者退款时，会提供此字段，用于透出子单具体的错误场景
        /// </summary>
        [XmlElement("sub_order_error_code")]
        public string SubOrderErrorCode { get; set; }

        /// <summary>
        /// 特殊场景提供，当子单出现异常导致主单失败或者退款时，会提供此字段，用于透出子单具体的错误场景
        /// </summary>
        [XmlElement("sub_order_fail_reason")]
        public string SubOrderFailReason { get; set; }

        /// <summary>
        /// 退款子单失败状态
        /// </summary>
        [XmlElement("sub_order_status")]
        public string SubOrderStatus { get; set; }

        /// <summary>
        /// 转账单据子状态，SUCCESS：二阶段转账领取成功；REFUNDED：二阶段转账退款
        /// </summary>
        [XmlElement("sub_status")]
        public string SubStatus { get; set; }

        /// <summary>
        /// 付款金额，收银台场景下付款成功后的支付金额，订单状态为SUCCESS才返回，其他状态不返回。付款金额，单位为元，精确到小数点后两位。
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 商户在查询代发订单信息时返回其在代发请求中传入的账单属性。
        /// </summary>
        [XmlElement("transfer_bill_info")]
        public string TransferBillInfo { get; set; }
    }
}
