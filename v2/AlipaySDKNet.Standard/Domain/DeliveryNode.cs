using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryNode Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryNode : AopObject
    {
        /// <summary>
        /// 节点描述，传中文，蚂蚁不做校验
        /// </summary>
        [XmlElement("node_desc")]
        public string NodeDesc { get; set; }

        /// <summary>
        /// 传中文，蚂蚁不做校验
        /// </summary>
        [XmlElement("node_name")]
        public string NodeName { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
