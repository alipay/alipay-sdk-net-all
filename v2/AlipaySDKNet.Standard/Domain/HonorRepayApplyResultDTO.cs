using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorRepayApplyResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorRepayApplyResultDTO : AopObject
    {
        /// <summary>
        /// 荣耀用户ID
        /// </summary>
        [XmlElement("channel_customer_id")]
        public string ChannelCustomerId { get; set; }

        /// <summary>
        /// 荣耀侧借款申请订单号
        /// </summary>
        [XmlElement("loan_apply_no")]
        public string LoanApplyNo { get; set; }

        /// <summary>
        /// 蚂蚁借款申请流水号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 还款交易流水号
        /// </summary>
        [XmlElement("out_repay_no")]
        public string OutRepayNo { get; set; }

        /// <summary>
        /// 还款金额，单位：分
        /// </summary>
        [XmlElement("repay_amount")]
        public string RepayAmount { get; set; }

        /// <summary>
        /// 荣耀侧还款交易流水号，批扣或线下还款时没有
        /// </summary>
        [XmlElement("repay_no")]
        public string RepayNo { get; set; }

        /// <summary>
        /// 还款失败原因
        /// </summary>
        [XmlElement("repay_result")]
        public string RepayResult { get; set; }

        /// <summary>
        /// 还款来源 主动还款：PARTNER_IN-APP_REPAYMENT 批扣还款、线下还款：OTHER
        /// </summary>
        [XmlElement("repay_source")]
        public string RepaySource { get; set; }

        /// <summary>
        /// 还款状态，2-还款成功，4-还款失败
        /// </summary>
        [XmlElement("repay_status")]
        public long RepayStatus { get; set; }

        /// <summary>
        /// 还款期次明细列表
        /// </summary>
        [XmlArray("repay_terms")]
        [XmlArrayItem("honor_repay_apply_term_d_t_o")]
        public List<HonorRepayApplyTermDTO> RepayTerms { get; set; }

        /// <summary>
        /// 还款时间，毫秒
        /// </summary>
        [XmlElement("repay_time")]
        public long RepayTime { get; set; }
    }
}
