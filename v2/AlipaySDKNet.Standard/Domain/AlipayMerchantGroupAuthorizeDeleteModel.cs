using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupAuthorizeDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupAuthorizeDeleteModel : AopObject
    {
        /// <summary>
        /// 授权记录id
        /// </summary>
        [XmlElement("authorize_id")]
        public string AuthorizeId { get; set; }
    }
}
