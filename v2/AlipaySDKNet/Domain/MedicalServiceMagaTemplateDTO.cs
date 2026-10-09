using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalServiceMagaTemplateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalServiceMagaTemplateDTO : AopObject
    {
        /// <summary>
        /// 服务数量
        /// </summary>
        [XmlElement("card_count")]
        public long CardCount { get; set; }

        /// <summary>
        /// 服务卡片列表
        /// </summary>
        [XmlArray("card_list")]
        [XmlArrayItem("medical_service_maga_card_d_t_o")]
        public List<MedicalServiceMagaCardDTO> CardList { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
