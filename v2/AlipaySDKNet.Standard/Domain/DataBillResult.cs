using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DataBillResult Data Structure.
    /// </summary>
    [Serializable]
    public class DataBillResult : AopObject
    {
        /// <summary>
        /// 活动名
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动类型，枚举：GMV\促活\促绑
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 银行清算号16位/31位
        /// </summary>
        [XmlElement("bank_bill_no")]
        public string BankBillNo { get; set; }

        /// <summary>
        /// 银行简称
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行分行信息
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 交易日期，格式为yyyyMMdd
        /// </summary>
        [XmlElement("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 交易时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 实际交易金额，提现金额
        /// </summary>
        [XmlElement("real_pay_amt")]
        public string RealPayAmt { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("trade_total_amt")]
        public string TradeTotalAmt { get; set; }

        /// <summary>
        /// 用户交易笔数排序
        /// </summary>
        [XmlElement("user_trd_cnt_rank")]
        public string UserTrdCntRank { get; set; }
    }
}
