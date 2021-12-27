using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankMarketingBkcustgrowprodCardstyleCreateResponse.
    /// </summary>
    public class MybankMarketingBkcustgrowprodCardstyleCreateResponse : AopResponse
    {
        /// <summary>
        /// 是否切换成功
        /// </summary>
        [XmlElement("selected")]
        public bool Selected { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("style_id")]
        public string StyleId { get; set; }

        /// <summary>
        /// success,业务处理状态，不唯一，Boolea类型
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
