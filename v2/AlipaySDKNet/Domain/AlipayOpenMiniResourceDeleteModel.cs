using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniResourceDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniResourceDeleteModel : AopObject
    {
        /// <summary>
        /// 流量位id，只能删除属于自己的流量位id
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }
    }
}
