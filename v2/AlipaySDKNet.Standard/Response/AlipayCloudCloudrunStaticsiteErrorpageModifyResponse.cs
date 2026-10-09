using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteErrorpageModifyResponse.
    /// </summary>
    public class AlipayCloudCloudrunStaticsiteErrorpageModifyResponse : AopResponse
    {
        /// <summary>
        /// 需要修改错误页面的域名列表
        /// </summary>
        [XmlArray("domain_list")]
        [XmlArrayItem("string")]
        public List<string> DomainList { get; set; }

        /// <summary>
        /// 错误页面配置
        /// </summary>
        [XmlElement("error_page")]
        public ErrorPageSetting ErrorPage { get; set; }
    }
}
