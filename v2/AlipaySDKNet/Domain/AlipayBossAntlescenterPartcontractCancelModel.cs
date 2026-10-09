using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossAntlescenterPartcontractCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossAntlescenterPartcontractCancelModel : AopObject
    {
        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
