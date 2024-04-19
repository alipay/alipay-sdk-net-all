using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionEnvvarsGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionEnvvarsGetResponse : AopResponse
    {
        /// <summary>
        /// 环境变量集合
        /// </summary>
        [XmlArray("env_vars")]
        [XmlArrayItem("env_var")]
        public List<EnvVar> EnvVars { get; set; }
    }
}
