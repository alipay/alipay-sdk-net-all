using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossAntlescenterPartcontractFinishResponse.
    /// </summary>
    public class AlipayBossAntlescenterPartcontractFinishResponse : AopResponse
    {
        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }
    }
}
