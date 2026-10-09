using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteErrorpageModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunStaticsiteErrorpageModifyModel : AopObject
    {
        /// <summary>
        /// 内部使用，uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

        /// <summary>
        /// 需要配置错误页面的域名列表，列表中的域名必须是此环境下的默认域名或者自定义域名
        /// </summary>
        [XmlArray("domain_list")]
        [XmlArrayItem("string")]
        public List<string> DomainList { get; set; }

        /// <summary>
        /// 环境ID，唯一，开通小程序云系统会生成环境ID，请从开通页面获取
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 自定义错误页面配置，当前仅支持配置404错误页
        /// </summary>
        [XmlElement("error_page")]
        public ErrorPageSetting ErrorPage { get; set; }
    }
}
