using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvEnvvarsSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseEnvEnvvarsSetModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 环境变量集合
        /// </summary>
        [XmlArray("env_vars")]
        [XmlArrayItem("env_var")]
        public List<EnvVar> EnvVars { get; set; }
    }
}
