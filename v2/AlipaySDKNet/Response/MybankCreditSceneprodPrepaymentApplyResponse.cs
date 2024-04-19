using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSceneprodPrepaymentApplyResponse.
    /// </summary>
    public class MybankCreditSceneprodPrepaymentApplyResponse : AopResponse
    {
        /// <summary>
        /// 是否可以提前还款  提前还款试算时必须先判断accept_repay="Y",如果="N"金额字段为空
        /// </summary>
        [XmlElement("accept_repay")]
        public string AcceptRepay { get; set; }

        /// <summary>
        /// 枚举值 a.退车 loanCancel b.机构主动回购 activeRefund c.客户主动结清 repayByCust
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 交易失败明细提示  提前还款结果查询时，如果tradeStatus=FAIL，failReason字段显示提前还款失败原因。
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 提前还款总金额（单位分）
        /// </summary>
        [XmlElement("prepayment_amt")]
        public string PrepaymentAmt { get; set; }

        /// <summary>
        /// 提前还款申请单号  提前还款申请后，如受理成功会返回。其余场景无返回值。
        /// </summary>
        [XmlElement("prepayment_apply_no")]
        public string PrepaymentApplyNo { get; set; }

        /// <summary>
        /// 提前还款利息（单位分）
        /// </summary>
        [XmlElement("prepayment_int_amt")]
        public string PrepaymentIntAmt { get; set; }

        /// <summary>
        /// 提前还款罚金（单位分）
        /// </summary>
        [XmlElement("prepayment_pen_amt")]
        public string PrepaymentPenAmt { get; set; }

        /// <summary>
        /// 提前还款本金(单位分)
        /// </summary>
        [XmlElement("prepayment_prin_amt")]
        public string PrepaymentPrinAmt { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// tradeStatus为提前还款结果查询时返回
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
