using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniResourceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniResourceQueryModel : AopObject
    {
        /// <summary>
        /// 流量位名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 页码 默认1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量 默认10, 最大10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 流量位id
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }
    }
}
