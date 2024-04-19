using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoContractsLoanInfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoContractsLoanInfoSyncModel : AopObject
    {
        /// <summary>
        /// 合约信息列表
        /// </summary>
        [XmlArray("contracts")]
        [XmlArrayItem("eco_contract_info")]
        public List<EcoContractInfo> Contracts { get; set; }

        /// <summary>
        /// 同步请求id，幂等使用
        /// </summary>
        [XmlElement("sync_request_id")]
        public string SyncRequestId { get; set; }
    }
}
