using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommercePurchaseCancelResponse.
    /// </summary>
    public class AlipayInsSceneEcommercePurchaseCancelResponse : AopResponse
    {
        /// <summary>
        /// 订购合约id
        /// </summary>
        [XmlElement("purchase_contract_id")]
        public string PurchaseContractId { get; set; }
    }
}
