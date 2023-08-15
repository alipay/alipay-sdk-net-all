using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageCacheruleDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunObjectstorageCacheruleDeleteModel : AopObject
    {
        /// <summary>
        /// 内部使用 uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

        /// <summary>
        /// 缓存键
        /// </summary>
        [XmlElement("cache_key")]
        public string CacheKey { get; set; }

        /// <summary>
        /// 缓存类型。 目录：为某一路径下所有资源设置相同缓存规则。 文件后缀名：为某一文件类型资源的设置相同缓存规则。
        /// </summary>
        [XmlElement("cache_type")]
        public string CacheType { get; set; }

        /// <summary>
        /// 环境ID，唯一，开通小程序云系统会生成环境ID，请从开通页面获取
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
