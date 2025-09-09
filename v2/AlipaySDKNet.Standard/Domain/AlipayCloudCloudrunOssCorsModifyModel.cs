using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunOssCorsModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunOssCorsModifyModel : AopObject
    {
        /// <summary>
        /// 允许跨域域名列表。 域名列表支持配置*，表示任意来源。 值非*的场景下，格式必须包含协议头http://或者https://，支持带端口。
        /// </summary>
        [XmlArray("access_control_allow_origins")]
        [XmlArrayItem("string")]
        public List<string> AccessControlAllowOrigins { get; set; }

        /// <summary>
        /// 预检请求有效期，单位秒，范围[0, 86400]。
        /// </summary>
        [XmlElement("access_control_max_age")]
        public long AccessControlMaxAge { get; set; }

        /// <summary>
        /// 内部使用，uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

        /// <summary>
        /// 是否开启跨域配置
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 环境ID，唯一，开通小程序云系统会生成环境ID，请从开通页面获取
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
