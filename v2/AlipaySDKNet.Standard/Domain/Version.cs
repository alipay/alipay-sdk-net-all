using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Version Data Structure.
    /// </summary>
    [Serializable]
    public class Version : AopObject
    {
        /// <summary>
        /// 版本描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 环境变量集合
        /// </summary>
        [XmlArray("env_vars")]
        [XmlArrayItem("env_var")]
        public List<EnvVar> EnvVars { get; set; }

        /// <summary>
        /// 版本列表
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否为最新版本
        /// </summary>
        [XmlElement("latest")]
        public bool Latest { get; set; }

        /// <summary>
        /// 空闲等待时间
        /// </summary>
        [XmlElement("max_idle_timeout")]
        public long MaxIdleTimeout { get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        [XmlElement("max_req_timeout")]
        public long MaxReqTimeout { get; set; }

        /// <summary>
        /// 重试次数
        /// </summary>
        [XmlElement("max_retry_time")]
        public long MaxRetryTime { get; set; }

        /// <summary>
        /// 版本名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
