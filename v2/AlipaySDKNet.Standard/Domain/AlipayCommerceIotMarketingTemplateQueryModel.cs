using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotMarketingTemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMarketingTemplateQueryModel : AopObject
    {
        /// <summary>
        /// 模版id集合，用于查询模版信息
        /// </summary>
        [XmlArray("template_ids")]
        [XmlArrayItem("string")]
        public List<string> TemplateIds { get; set; }
    }
}
