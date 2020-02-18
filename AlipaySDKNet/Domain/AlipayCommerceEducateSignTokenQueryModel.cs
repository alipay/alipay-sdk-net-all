using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSignTokenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSignTokenQueryModel : AopObject
    {
        /// <summary>
        /// 加密TOKEN
        /// </summary>
        [XmlElement("token_key")]
        public string TokenKey { get; set; }
    }
}
