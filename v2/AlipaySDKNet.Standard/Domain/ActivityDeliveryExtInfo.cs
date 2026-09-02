using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityDeliveryExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityDeliveryExtInfo : AopObject
    {
        /// <summary>
        /// 是否自动推广
        /// </summary>
        [XmlElement("auto_delivery")]
        public bool AutoDelivery { get; set; }

        /// <summary>
        /// 推广渠道列表
        /// </summary>
        [XmlArray("channel_list")]
        [XmlArrayItem("string")]
        public List<string> ChannelList { get; set; }
    }
}
