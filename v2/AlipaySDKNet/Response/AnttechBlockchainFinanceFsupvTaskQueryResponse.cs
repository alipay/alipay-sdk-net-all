using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvTaskQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceFsupvTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金管控任务编号
        /// </summary>
        [XmlElement("fund_supv_task_id")]
        public string FundSupvTaskId { get; set; }

        /// <summary>
        /// 被管控方脱敏登录号
        /// </summary>
        [XmlElement("supervised_desensitized_access_no")]
        public string SupervisedDesensitizedAccessNo { get; set; }

        /// <summary>
        /// 资金管控专户号
        /// </summary>
        [XmlElement("supervised_special_account_no")]
        public string SupervisedSpecialAccountNo { get; set; }

        /// <summary>
        /// 资金管控协议编号
        /// </summary>
        [XmlElement("supv_agreement_no")]
        public string SupvAgreementNo { get; set; }

        /// <summary>
        /// 资金管控终止日期
        /// </summary>
        [XmlElement("supv_end")]
        public string SupvEnd { get; set; }

        /// <summary>
        /// 资金管控开始时间
        /// </summary>
        [XmlElement("supv_start")]
        public string SupvStart { get; set; }
    }
}
