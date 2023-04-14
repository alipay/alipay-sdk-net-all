using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoAccessBaseCatalogVO Data Structure.
    /// </summary>
    [Serializable]
    public class PromoAccessBaseCatalogVO : AopObject
    {
        /// <summary>
        /// 类目节点描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 类目节点名称
        /// </summary>
        [XmlElement("node_name")]
        public string NodeName { get; set; }

        /// <summary>
        /// 类目节点ID
        /// </summary>
        [XmlElement("nodei_d")]
        public string NodeiD { get; set; }
    }
}
