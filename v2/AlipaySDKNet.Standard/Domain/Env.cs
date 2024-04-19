using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Env Data Structure.
    /// </summary>
    [Serializable]
    public class Env : AopObject
    {
        /// <summary>
        /// api网关AK
        /// </summary>
        [XmlElement("cloudbase_api_gateway_ak")]
        public string CloudbaseApiGatewayAk { get; set; }

        /// <summary>
        /// api网关SK
        /// </summary>
        [XmlElement("cloudbase_api_gateway_sk")]
        public string CloudbaseApiGatewaySk { get; set; }

        /// <summary>
        /// 环境描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 外部环境id
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 环境级别的环境变量
        /// </summary>
        [XmlArray("env_vars")]
        [XmlArrayItem("env_var")]
        public List<EnvVar> EnvVars { get; set; }

        /// <summary>
        /// 环境名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 资源包到期时间
        /// </summary>
        [XmlElement("pkg_expiration_time")]
        public string PkgExpirationTime { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 环境状态  - INIT  - ENABLE  - SYSTEM_DISABLE
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 资源包名称
        /// </summary>
        [XmlElement("workspace_pkg_name")]
        public string WorkspacePkgName { get; set; }
    }
}
