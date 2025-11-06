using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodGfcontractcenterCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodGfcontractcenterCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 用于承载合同同步信息
        /// </summary>
        [XmlElement("contract_change_sync_request")]
        public ContractChangeSyncRequest ContractChangeSyncRequest { get; set; }
    }
}
