using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoContractProcessSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoContractProcessSyncModel : AopObject
    {
        /// <summary>
        /// MCCCode
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 流程信息
        /// </summary>
        [XmlArray("flows")]
        [XmlArrayItem("contract_manager_process_sync_request")]
        public List<ContractManagerProcessSyncRequest> Flows { get; set; }

        /// <summary>
        /// 签署平台的代码
        /// </summary>
        [XmlElement("sign_platform_code")]
        public string SignPlatformCode { get; set; }
    }
}
