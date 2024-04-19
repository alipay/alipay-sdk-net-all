using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignSolutionSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthEcsignSolutionSaveModel : AopObject
    {
        /// <summary>
        /// ecsign解决方案属性信息开放试图对象，主要用于承载服务载体等信息，不能为空。
        /// </summary>
        [XmlArray("attribute_vo_list")]
        [XmlArrayItem("solution_attribute_info_open_v_o")]
        public List<SolutionAttributeInfoOpenVO> AttributeVoList { get; set; }

        /// <summary>
        /// 拓展模式，需要与蚂蚁这边咨询具体入参，没有则可空。
        /// </summary>
        [XmlElement("extend_mode")]
        public string ExtendMode { get; set; }

        /// <summary>
        /// 解决方案码，唯一值，如果传入则表示更新，如果未传入表示新增。
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }

        /// <summary>
        /// 解决方案示例值，由用户输入。
        /// </summary>
        [XmlElement("solution_desc")]
        public string SolutionDesc { get; set; }

        /// <summary>
        /// 解决方案名称，非唯一值，必传。
        /// </summary>
        [XmlElement("solution_name")]
        public string SolutionName { get; set; }

        /// <summary>
        /// 模板列表，可空，VO参数中只需要传templateId,mustRest两个参数就行。
        /// </summary>
        [XmlArray("template_vo_list")]
        [XmlArrayItem("contract_template_open_v_o")]
        public List<ContractTemplateOpenVO> TemplateVoList { get; set; }
    }
}
