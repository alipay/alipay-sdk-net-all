using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardUnit Data Structure.
    /// </summary>
    [Serializable]
    public class CardUnit : AopObject
    {
        /// <summary>
        /// 模板类型
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模版数据，包含文本、标题、卡片数据
        /// </summary>
        [XmlElement("template_data")]
        public TemplateDataDTO TemplateData { get; set; }
    }
}
