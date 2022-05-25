using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationSsmmmmmCaptureModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationSsmmmmmCaptureModel : AopObject
    {
        /// <summary>
        /// d
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("s")]
        public ManjiangTesttttttt S { get; set; }
    }
}
