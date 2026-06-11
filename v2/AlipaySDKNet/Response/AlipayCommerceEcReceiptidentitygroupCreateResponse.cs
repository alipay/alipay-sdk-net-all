using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcReceiptidentitygroupCreateResponse.
    /// </summary>
    public class AlipayCommerceEcReceiptidentitygroupCreateResponse : AopResponse
    {
        /// <summary>
        /// 收单身份组id
        /// </summary>
        [XmlElement("identity_group_id")]
        public string IdentityGroupId { get; set; }
    }
}
