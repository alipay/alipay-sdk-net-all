using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsVoiceTemplateQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsVoiceTemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("template_list")]
        [XmlArrayItem("logistics_voice_template")]
        public List<LogisticsVoiceTemplate> TemplateList { get; set; }

        /// <summary>
        /// 模板总数
        /// </summary>
        [XmlElement("total")]
        public string Total { get; set; }
    }
}
