using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupvFundTask Data Structure.
    /// </summary>
    [Serializable]
    public class SupvFundTask : AopObject
    {
        /// <summary>
        /// 资金管控任务编号
        /// </summary>
        [XmlElement("fund_supv_task_id")]
        public string FundSupvTaskId { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 脱敏的支付宝登录号
        /// </summary>
        [XmlElement("supervised_desensitized_access_no")]
        public string SupervisedDesensitizedAccessNo { get; set; }

        /// <summary>
        /// 被管控方身份ID
        /// </summary>
        [XmlElement("supervised_id_number")]
        public string SupervisedIdNumber { get; set; }

        /// <summary>
        /// 被管控方名称
        /// </summary>
        [XmlElement("supervised_name")]
        public string SupervisedName { get; set; }

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
        /// 结束日期
        /// </summary>
        [XmlElement("supv_end")]
        public string SupvEnd { get; set; }

        /// <summary>
        /// 起始日期
        /// </summary>
        [XmlElement("supv_start")]
        public string SupvStart { get; set; }

        /// <summary>
        /// 管控方企业社会信用编码
        /// </summary>
        [XmlElement("supvervisor_id_number")]
        public string SupvervisorIdNumber { get; set; }

        /// <summary>
        /// 管控方名称
        /// </summary>
        [XmlElement("supvervisor_name")]
        public string SupvervisorName { get; set; }
    }
}
