using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinRepaymentNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinRepaymentNotifyModel : AopObject
    {
        /// <summary>
        /// 星河侧唯一业务编号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 还款银行卡信息
        /// </summary>
        [XmlElement("bank_card")]
        public BankCardSimpleInfo BankCard { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("drawdown_info_list")]
        [XmlArrayItem("drawdown_info")]
        public List<DrawdownInfo> DrawdownInfoList { get; set; }

        /// <summary>
        /// 还款失败code
        /// </summary>
        [XmlElement("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 还款失败描述
        /// </summary>
        [XmlElement("fail_msg")]
        public string FailMsg { get; set; }

        /// <summary>
        /// 通知类型  1 状态通知 2 机构侧还款通知
        /// </summary>
        [XmlElement("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("org_drawdown_no_list")]
        [XmlArrayItem("string")]
        public List<string> OrgDrawdownNoList { get; set; }

        /// <summary>
        /// 机构侧唯一业务编号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 机构侧外部还款单号
        /// </summary>
        [XmlElement("out_repayment_no")]
        public string OutRepaymentNo { get; set; }

        /// <summary>
        /// 退款状态。REFUNDING：退款中；REFUND_SUCCESS：退款成功 NOT_DEDUCTED：未扣款
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 星河侧还款单号
        /// </summary>
        [XmlElement("repayment_no")]
        public string RepaymentNo { get; set; }

        /// <summary>
        /// 还款状态
        /// </summary>
        [XmlElement("repayment_status")]
        public string RepaymentStatus { get; set; }

        /// <summary>
        /// 还款时间
        /// </summary>
        [XmlElement("repayment_time")]
        public string RepaymentTime { get; set; }

        /// <summary>
        /// 总还款金额 单位元 notify_type=2等于借据列表总金额相加
        /// </summary>
        [XmlElement("repayment_total_amt")]
        public string RepaymentTotalAmt { get; set; }

        /// <summary>
        /// 还款类型
        /// </summary>
        [XmlElement("repayment_type")]
        public string RepaymentType { get; set; }
    }
}
