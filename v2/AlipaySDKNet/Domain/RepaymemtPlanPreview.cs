using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepaymemtPlanPreview Data Structure.
    /// </summary>
    [Serializable]
    public class RepaymemtPlanPreview : AopObject
    {
        /// <summary>
        /// 每期优惠利息，单位：元
        /// </summary>
        [XmlElement("deduct_int_amt")]
        public string DeductIntAmt { get; set; }

        /// <summary>
        /// 每期到期还款日
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 每期原始利息，单位：元
        /// </summary>
        [XmlElement("initial_int_amt")]
        public string InitialIntAmt { get; set; }

        /// <summary>
        /// 每期还款利息，单位：元；字段间关系为 每期还款利息 = 每期原始利息 - 每期优惠利息
        /// </summary>
        [XmlElement("repay_int_amt")]
        public string RepayIntAmt { get; set; }

        /// <summary>
        /// 是 每期还款本金，单位：元
        /// </summary>
        [XmlElement("repay_prin_amt")]
        public string RepayPrinAmt { get; set; }

        /// <summary>
        /// 每期还款总额，单位：元
        /// </summary>
        [XmlElement("repay_total_amt")]
        public string RepayTotalAmt { get; set; }

        /// <summary>
        /// 每期担保费或及服务费，单位：元
        /// </summary>
        [XmlElement("serv_amt")]
        public string ServAmt { get; set; }

        /// <summary>
        /// 还款期次
        /// </summary>
        [XmlElement("term_no")]
        public string TermNo { get; set; }
    }
}
