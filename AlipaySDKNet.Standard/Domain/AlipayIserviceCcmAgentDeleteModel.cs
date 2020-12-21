using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmAgentDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmAgentDeleteModel : AopObject
    {
        /// <summary>
        /// 客服id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
