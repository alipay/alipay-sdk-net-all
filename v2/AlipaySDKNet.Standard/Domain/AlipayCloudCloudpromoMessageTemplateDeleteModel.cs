using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageTemplateDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMessageTemplateDeleteModel : AopObject
    {
        /// <summary>
        /// 短信模板Code
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
