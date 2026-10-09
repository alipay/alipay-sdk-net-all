using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlescenterPartcontractreviewQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlescenterPartcontractreviewQueryModel : AopObject
    {
        /// <summary>
        /// 审核类型
        /// </summary>
        [XmlElement("audit_type")]
        public string AuditType { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }
    }
}
