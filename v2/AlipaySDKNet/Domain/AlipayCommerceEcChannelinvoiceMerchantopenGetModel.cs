using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcChannelinvoiceMerchantopenGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcChannelinvoiceMerchantopenGetModel : AopObject
    {
        /// <summary>
        /// 乐企开通流水 ID
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }
    }
}
