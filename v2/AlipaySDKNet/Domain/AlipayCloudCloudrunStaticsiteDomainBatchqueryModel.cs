using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteDomainBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunStaticsiteDomainBatchqueryModel : AopObject
    {
        /// <summary>
        /// 内部使用，uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

        /// <summary>
        /// 域名。输入你的自定义域名精确查找。
        /// </summary>
        [XmlElement("domain_name")]
        public string DomainName { get; set; }

        /// <summary>
        /// 域名类型。默认域名为系统自动分配的域名，自定义域名为你自己添加的自定义域名。
        /// </summary>
        [XmlElement("domain_type")]
        public string DomainType { get; set; }

        /// <summary>
        /// 环境ID，唯一，开通小程序云系统会生成环境ID，请从开通页面获取
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
