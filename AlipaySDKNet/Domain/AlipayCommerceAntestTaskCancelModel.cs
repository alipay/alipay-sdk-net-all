using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAntestTaskCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAntestTaskCancelModel : AopObject
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("batch_id")]
        public long BatchId { get; set; }
    }
}
