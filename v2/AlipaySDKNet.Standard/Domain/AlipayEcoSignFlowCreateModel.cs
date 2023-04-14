using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoSignFlowCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoSignFlowCreateModel : AopObject
    {
        /// <summary>
        /// 附件信息
        /// </summary>
        [XmlArray("attachments")]
        [XmlArrayItem("attachment")]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// 流程主题
        /// </summary>
        [XmlElement("business_scene")]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 流程配置信息
        /// </summary>
        [XmlElement("config_info")]
        public ConfigInfo ConfigInfo { get; set; }

        /// <summary>
        /// 模板信息
        /// </summary>
        [XmlArray("template_infos")]
        [XmlArrayItem("template_info")]
        public List<TemplateInfo> TemplateInfos { get; set; }
    }
}
