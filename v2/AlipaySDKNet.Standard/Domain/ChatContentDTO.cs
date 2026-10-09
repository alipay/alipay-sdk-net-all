using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatContentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ChatContentDTO : AopObject
    {
        /// <summary>
        /// 展示序号
        /// </summary>
        [XmlElement("index")]
        public long Index { get; set; }

        /// <summary>
        /// 模版数据，挂号agent返回的卡片数据会存放于此
        /// </summary>
        [XmlElement("template_data")]
        public TemplateDataDTO TemplateData { get; set; }

        /// <summary>
        /// 模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模版类型
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }
    }
}
