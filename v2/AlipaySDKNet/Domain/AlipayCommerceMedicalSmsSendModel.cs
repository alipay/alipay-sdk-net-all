using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalSmsSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalSmsSendModel : AopObject
    {
        /// <summary>
        /// 履约单ID
        /// </summary>
        [XmlElement("fulfill_order_id")]
        public string FulfillOrderId { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 短信模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板参数
        /// </summary>
        [XmlElement("template_value")]
        public string TemplateValue { get; set; }
    }
}
