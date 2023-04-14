using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderHahaNobizcontentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderHahaNobizcontentCreateModel : AopObject
    {
        /// <summary>
        /// delete
        /// </summary>
        [XmlElement("delete")]
        public string Delete { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("input")]
        public string Input { get; set; }
    }
}
