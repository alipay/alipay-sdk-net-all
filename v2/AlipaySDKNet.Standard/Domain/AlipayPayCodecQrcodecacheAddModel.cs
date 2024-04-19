using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayCodecQrcodecacheAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayCodecQrcodecacheAddModel : AopObject
    {
        /// <summary>
        /// 是否需要gzip压缩
        /// </summary>
        [XmlElement("compress")]
        public bool Compress { get; set; }

        /// <summary>
        /// 批量json的键值对
        /// </summary>
        [XmlArray("json")]
        [XmlArrayItem("string")]
        public List<string> Json { get; set; }

        /// <summary>
        /// bizType_gridId
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 缓存时长，单位是秒
        /// </summary>
        [XmlElement("time")]
        public long Time { get; set; }

        /// <summary>
        /// 码地址静态信息分隔符码地址静态信息
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
