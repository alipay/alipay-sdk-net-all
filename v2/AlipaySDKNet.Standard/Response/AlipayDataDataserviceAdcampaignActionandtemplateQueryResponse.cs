using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignActionandtemplateQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignActionandtemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 创意模版与交互类型返回结果集合
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("creative_action_and_template_response")]
        public List<CreativeActionAndTemplateResponse> ResultList { get; set; }
    }
}
