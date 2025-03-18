using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneCommonRunningcontractQueryResponse.
    /// </summary>
    public class AlipayInsSceneCommonRunningcontractQueryResponse : AopResponse
    {
        /// <summary>
        /// 订购合约摘要
        /// </summary>
        [XmlElement("contract_digest")]
        public InsOpenPurchaseContractInfoDigestDTO ContractDigest { get; set; }
    }
}
