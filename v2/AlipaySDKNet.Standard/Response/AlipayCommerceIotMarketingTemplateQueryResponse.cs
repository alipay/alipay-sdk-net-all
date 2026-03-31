using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotMarketingTemplateQueryResponse.
    /// </summary>
    public class AlipayCommerceIotMarketingTemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务商投放模版列表信息
        /// </summary>
        [XmlArray("template_info_list")]
        [XmlArrayItem("i_s_p_template_info")]
        public List<ISPTemplateInfo> TemplateInfoList { get; set; }
    }
}
