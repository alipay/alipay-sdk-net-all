using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossAntlescenterPartcontractCancelResponse.
    /// </summary>
    public class AlipayBossAntlescenterPartcontractCancelResponse : AopResponse
    {
        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }
    }
}
