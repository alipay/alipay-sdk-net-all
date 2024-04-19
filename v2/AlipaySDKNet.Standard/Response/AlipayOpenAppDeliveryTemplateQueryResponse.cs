using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppDeliveryTemplateQueryResponse.
    /// </summary>
    public class AlipayOpenAppDeliveryTemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 属性信息
        /// </summary>
        [XmlElement("attrs")]
        public AttributeVO Attrs { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// 履约模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
