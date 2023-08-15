using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteDomaincertQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunStaticsiteDomaincertQueryModel : AopObject
    {
        /// <summary>
        /// 内部使用，uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

        /// <summary>
        /// 域名。请输入域名。
        /// </summary>
        [XmlElement("domain_name")]
        public string DomainName { get; set; }

        /// <summary>
        /// 环境ID，唯一，开通小程序云系统会生成环境ID，请从开通页面获取
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
