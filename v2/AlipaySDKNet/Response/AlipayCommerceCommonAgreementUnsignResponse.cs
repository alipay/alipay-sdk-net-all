using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonAgreementUnsignResponse.
    /// </summary>
    public class AlipayCommerceCommonAgreementUnsignResponse : AopResponse
    {
        /// <summary>
        /// 已解约的支付宝签约id
        /// </summary>
        [XmlElement("sign_id")]
        public string SignId { get; set; }
    }
}
