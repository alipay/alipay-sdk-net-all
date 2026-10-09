using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftAccountOverseaCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftAccountOverseaCreateModel : AopObject
    {
        /// <summary>
        /// aldaba链上地址
        /// </summary>
        [XmlElement("blockchain_address")]
        public string BlockchainAddress { get; set; }
    }
}
