using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalServiceMagaDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalServiceMagaDTO : AopObject
    {
        /// <summary>
        /// 数据区块列表
        /// </summary>
        [XmlArray("template_list")]
        [XmlArrayItem("medical_service_maga_template_d_t_o")]
        public List<MedicalServiceMagaTemplateDTO> TemplateList { get; set; }
    }
}
