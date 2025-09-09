using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpExecuteDefendantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpExecuteDefendantInfo : AopObject
    {
        /// <summary>
        /// 案号
        /// </summary>
        [XmlElement("case_no")]
        public string CaseNo { get; set; }

        /// <summary>
        /// 立案时间
        /// </summary>
        [XmlElement("case_register_date")]
        public string CaseRegisterDate { get; set; }

        /// <summary>
        /// 案件状态
        /// </summary>
        [XmlElement("case_state")]
        public string CaseState { get; set; }

        /// <summary>
        /// 执行法院
        /// </summary>
        [XmlElement("execution_court")]
        public string ExecutionCourt { get; set; }

        /// <summary>
        /// 被执行人姓名/名称
        /// </summary>
        [XmlElement("performed_name")]
        public string PerformedName { get; set; }

        /// <summary>
        /// 执行标的
        /// </summary>
        [XmlElement("zxbd")]
        public string Zxbd { get; set; }

        /// <summary>
        /// 组织机构代码
        /// </summary>
        [XmlElement("zzjgdm")]
        public string Zzjgdm { get; set; }
    }
}
