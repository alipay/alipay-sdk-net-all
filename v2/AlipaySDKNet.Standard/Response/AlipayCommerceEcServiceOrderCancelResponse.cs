using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcServiceOrderCancelResponse.
    /// </summary>
    public class AlipayCommerceEcServiceOrderCancelResponse : AopResponse
    {
        /// <summary>
        /// 若需要解约则返回解约链接
        /// </summary>
        [XmlElement("cancel_contract_url")]
        public string CancelContractUrl { get; set; }
    }
}
