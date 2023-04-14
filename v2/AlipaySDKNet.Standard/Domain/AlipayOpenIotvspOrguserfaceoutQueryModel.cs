using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspOrguserfaceoutQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspOrguserfaceoutQueryModel : AopObject
    {
        /// <summary>
        /// 出库事件id
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }
    }
}
