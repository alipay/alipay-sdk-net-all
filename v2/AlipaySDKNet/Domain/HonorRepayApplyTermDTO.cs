using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorRepayApplyTermDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorRepayApplyTermDTO : AopObject
    {
        /// <summary>
        /// 本期还款总额，单位：分
        /// </summary>
        [XmlElement("term_amount")]
        public string TermAmount { get; set; }

        /// <summary>
        /// 本期还款利息，单位：分
        /// </summary>
        [XmlElement("term_interest")]
        public string TermInterest { get; set; }

        /// <summary>
        /// 期次
        /// </summary>
        [XmlElement("term_no")]
        public long TermNo { get; set; }

        /// <summary>
        /// 本期还款罚息，单位：分
        /// </summary>
        [XmlElement("term_penalty")]
        public string TermPenalty { get; set; }

        /// <summary>
        /// 本期还款本金，单位：分
        /// </summary>
        [XmlElement("term_principal")]
        public string TermPrincipal { get; set; }
    }
}
