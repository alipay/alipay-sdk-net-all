using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoContractFormInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoContractFormInitializeModel : AopObject
    {
        /// <summary>
        /// 用户主体id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 三方小程序id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
