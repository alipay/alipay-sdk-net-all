using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelCodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelCodeInfo : AopObject
    {
        /// <summary>
        /// 渠道的code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 渠道code对应的name
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
