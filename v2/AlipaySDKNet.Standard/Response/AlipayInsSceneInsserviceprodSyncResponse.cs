using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSyncResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSyncResponse : AopResponse
    {
        /// <summary>
        /// 节点描述信息
        /// </summary>
        [XmlElement("node_desc")]
        public string NodeDesc { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [XmlElement("node_name")]
        public string NodeName { get; set; }
    }
}
