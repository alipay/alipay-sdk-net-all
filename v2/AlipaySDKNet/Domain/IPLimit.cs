using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IPLimit Data Structure.
    /// </summary>
    [Serializable]
    public class IPLimit : AopObject
    {
        /// <summary>
        /// 是否开启
        /// </summary>
        [XmlElement("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// IP列表
        /// </summary>
        [XmlArray("ip_list")]
        [XmlArrayItem("string")]
        public List<string> IpList { get; set; }

        /// <summary>
        /// 限制类型
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }
    }
}
