using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniTemplatelistQueryResponse.
    /// </summary>
    public class AlipayOpenMiniTemplatelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 三方应用关联的小程序模板应用列表
        /// </summary>
        [XmlArray("app_list")]
        [XmlArrayItem("mini_template_app")]
        public List<MiniTemplateApp> AppList { get; set; }
    }
}
