using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CatalogNodeData Data Structure.
    /// </summary>
    [Serializable]
    public class CatalogNodeData : AopObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("node_nm")]
        public string NodeNm { get; set; }
    }
}
