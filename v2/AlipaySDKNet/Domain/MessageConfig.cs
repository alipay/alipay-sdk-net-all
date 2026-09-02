using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MessageConfig Data Structure.
    /// </summary>
    [Serializable]
    public class MessageConfig : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("channels")]
        [XmlArrayItem("channels")]
        public List<Channels> Channels { get; set; }

        /// <summary>
        /// 消息分发渠道
        /// </summary>
        [XmlElement("dispatch_mode")]
        public string DispatchMode { get; set; }
    }
}
