using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonAgreementSignResponse.
    /// </summary>
    public class AlipayCommerceCommonAgreementSignResponse : AopResponse
    {
        /// <summary>
        /// 支付宝签约id，全局唯一
        /// </summary>
        [XmlElement("sign_id")]
        public string SignId { get; set; }
    }
}
