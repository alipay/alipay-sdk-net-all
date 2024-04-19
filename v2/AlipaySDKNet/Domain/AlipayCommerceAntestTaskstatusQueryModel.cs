using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAntestTaskstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAntestTaskstatusQueryModel : AopObject
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }
    }
}
