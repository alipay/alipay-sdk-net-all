using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodGfcontractcenterCreateormodifyResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodGfcontractcenterCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 返回合同信息同步结果
        /// </summary>
        [XmlElement("contract_sync_response")]
        public ContractSyncResponse ContractSyncResponse { get; set; }
    }
}
