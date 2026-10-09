using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCardTemplateQueryResponse.
    /// </summary>
    public class AlipayCommerceCardTemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡模版数据
        /// </summary>
        [XmlElement("card_template_info")]
        public CardTemplateInfo CardTemplateInfo { get; set; }
    }
}
