using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupAutoreplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupAutoreplyQueryModel : AopObject
    {
        /// <summary>
        /// 自动回复id
        /// </summary>
        [XmlElement("autoreply_id")]
        public string AutoreplyId { get; set; }
    }
}
