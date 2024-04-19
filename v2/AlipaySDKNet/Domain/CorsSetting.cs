using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CorsSetting Data Structure.
    /// </summary>
    [Serializable]
    public class CorsSetting : AopObject
    {
        /// <summary>
        /// 允许跨域域名列表
        /// </summary>
        [XmlArray("access_control_allow_origins")]
        [XmlArrayItem("string")]
        public List<string> AccessControlAllowOrigins { get; set; }

        /// <summary>
        /// 预检请求有效期，单位秒
        /// </summary>
        [XmlElement("access_control_max_age")]
        public long AccessControlMaxAge { get; set; }

        /// <summary>
        /// 是否开启跨域配置
        /// </summary>
        [XmlElement("enabled")]
        public bool Enabled { get; set; }
    }
}
