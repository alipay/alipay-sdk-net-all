using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvGetResponse : AopResponse
    {
        /// <summary>
        /// 付费方式  - 套餐  - 计量计费
        /// </summary>
        [XmlElement("billing_model")]
        public string BillingModel { get; set; }

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
        /// 资源包创建时间
        /// </summary>
        [XmlElement("pkg_create_time")]
        public string PkgCreateTime { get; set; }

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
        /// 环境套餐资源包的状态
        /// </summary>
        [XmlElement("resource_pkg_status")]
        public string ResourcePkgStatus { get; set; }

        /// <summary>
        /// 环境状态    - INIT    - ACTIVATING_UNPAY    - ACTIVATING_PAY    - ENABLE("正常")    - MANUAL_DISABLE    - USER_DISABLE    - SYSTEM_DISABLE    - DELETED    - DELETING    - SYSTEM_SUSPENDING    - RECOVERING    - REFUNDING    - REFUND_SUCCESS    - REFUND_FAILED
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
