using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteCacheruleAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunStaticsiteCacheruleAddModel : AopObject
    {
        /// <summary>
        /// 内部使用，uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

        /// <summary>
        /// 缓存内容。类型选择目录时，填写规则如下： 每次只能添加单条目录，可以用正斜线（/）匹配所有目录。 支持输入目录的完整路径，须以正斜线（/）开头，例如/directory/aaa。 类型选择后缀名时，填写规则如下： 支持输入一个或多个文件后缀名，多个文件后缀名用半角逗号（,）分隔，例如jpg,txt。 大小写敏感，注意区分大小写。 不支持用星号（*）匹配所有的文件类型。
        /// </summary>
        [XmlElement("cache_key")]
        public string CacheKey { get; set; }

        /// <summary>
        /// 缓存优先级。数字越大，优先级越高
        /// </summary>
        [XmlElement("cache_priority")]
        public long CachePriority { get; set; }

        /// <summary>
        /// 缓存超时时间，秒为单位
        /// </summary>
        [XmlElement("cache_timeout")]
        public long CacheTimeout { get; set; }

        /// <summary>
        /// 缓存类型。目录：为某一路径下所有资源设置相同缓存规则。 后缀名：为某一文件类型资源的设置相同缓存规则。
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
