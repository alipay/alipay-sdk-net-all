using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteRefererModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunStaticsiteRefererModifyModel : AopObject
    {
        /// <summary>
        /// 内部使用，uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

        /// <summary>
        /// 是否开启
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 环境ID，唯一，开通小程序云系统会生成环境ID，请从开通页面获取
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 限制类型。 - 黑名单 黑名单内的域名均无法访问当前的资源。 - 白名单 只有白名单内的域名能访问当前资源，白名单以外的域名均无法访问当前的资源。
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }

        /// <summary>
        /// 是否允许空refer。默认允许
        /// </summary>
        [XmlElement("no_refer_access")]
        public bool NoReferAccess { get; set; }

        /// <summary>
        /// referer配置列表。域名或者域名加端口格式，比如a.com、b.com:8080
        /// </summary>
        [XmlArray("refer_list")]
        [XmlArrayItem("string")]
        public List<string> ReferList { get; set; }
    }
}
