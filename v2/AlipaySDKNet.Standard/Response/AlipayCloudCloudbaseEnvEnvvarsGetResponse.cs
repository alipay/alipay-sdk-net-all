using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvEnvvarsGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvEnvvarsGetResponse : AopResponse
    {
        /// <summary>
        /// 全局环境变量集合
        /// </summary>
        [XmlArray("env_vars")]
        [XmlArrayItem("env_var")]
        public List<EnvVar> EnvVars { get; set; }
    }
}
