using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CacheRule Data Structure.
    /// </summary>
    [Serializable]
    public class CacheRule : AopObject
    {
        /// <summary>
        /// 缓存键
        /// </summary>
        [XmlElement("cache_key")]
        public string CacheKey { get; set; }

        /// <summary>
        /// 缓存优先级，数字越大缓存优先级越高
        /// </summary>
        [XmlElement("cache_priority")]
        public long CachePriority { get; set; }

        /// <summary>
        /// 缓存超时时间，秒为单位
        /// </summary>
        [XmlElement("cache_timeout")]
        public long CacheTimeout { get; set; }

        /// <summary>
        /// 缓存类型
        /// </summary>
        [XmlElement("cache_type")]
        public string CacheType { get; set; }
    }
}
