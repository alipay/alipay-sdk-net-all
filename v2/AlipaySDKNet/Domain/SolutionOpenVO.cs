using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SolutionOpenVO Data Structure.
    /// </summary>
    [Serializable]
    public class SolutionOpenVO : AopObject
    {
        /// <summary>
        /// ecsign解决方案属性信息开放试图对象，主要用于承载服务载体等信息，不能为空。
        /// </summary>
        [XmlArray("attribute_vo_list")]
        [XmlArrayItem("solution_attribute_info_open_v_o")]
        public List<SolutionAttributeInfoOpenVO> AttributeVoList { get; set; }

        /// <summary>
        /// 用户模式扩展使用，可为空。
        /// </summary>
        [XmlElement("extend_mode")]
        public string ExtendMode { get; set; }

        /// <summary>
        /// 解决方案的创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 解决方案码，唯一值，又创建时系统生成。
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }

        /// <summary>
        /// 解决方案示例值，由用户输入。
        /// </summary>
        [XmlElement("solution_desc")]
        public string SolutionDesc { get; set; }

        /// <summary>
        /// 解决方案名称，非唯一值，有用户自行输入。
        /// </summary>
        [XmlElement("solution_name")]
        public string SolutionName { get; set; }

        /// <summary>
        /// 合同模板列表，解决方案详情接口查询出来仅包括模板ID及是否必读。
        /// </summary>
        [XmlArray("template_list")]
        [XmlArrayItem("contract_template_open_v_o")]
        public List<ContractTemplateOpenVO> TemplateList { get; set; }
    }
}
