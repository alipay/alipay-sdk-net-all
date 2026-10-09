using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommercePurchaseModifyResponse.
    /// </summary>
    public class AlipayInsSceneEcommercePurchaseModifyResponse : AopResponse
    {
        /// <summary>
        /// 订购合约id
        /// </summary>
        [XmlElement("purchase_contract_id")]
        public string PurchaseContractId { get; set; }
    }
}
