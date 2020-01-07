using System;
using System.Xml.Serialization;

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
