using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorLoanRecordDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorLoanRecordDTO : AopObject
    {
        /// <summary>
        /// 借款申请日期（用户申请时间）, yyyyMMdd
        /// </summary>
        [XmlElement("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 荣耀侧借款申请订单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 借款申请时间，毫秒
        /// </summary>
        [XmlElement("apply_time")]
        public long ApplyTime { get; set; }

        /// <summary>
        /// 借款金额，单位：分
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 蚂蚁侧借款订单单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 借款状态，1-申请中，2-正常还款中，3-已逾期，4-已结清，5-借款失败
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 借款期数
        /// </summary>
        [XmlElement("total_term")]
        public long TotalTerm { get; set; }
    }
}
