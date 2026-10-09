using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcsmartQtdialogueCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceRcsmartQtdialogueCheckModel : AopObject
    {
        /// <summary>
        /// app_name为调用方系统名称(英文名称),与分配的app_token一起做调用系统合法性校验。
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// app_token为系统分配的密钥，与app_name一起做调用系统合法性校验
        /// </summary>
        [XmlElement("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// 业务编码，一个业务biz_code代表当前业务，可以包含多个scene_code，与scene_code之间为一对多的关系。
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 阿里云和解语花交互的对话审核请求的唯一标识
        /// </summary>
        [XmlElement("dialogue_param")]
        public DialogueParam DialogueParam { get; set; }

        /// <summary>
        /// 对话内容列表
        /// </summary>
        [XmlArray("dialogues")]
        [XmlArrayItem("dialogue")]
        public List<Dialogue> Dialogues { get; set; }

        /// <summary>
        /// 场景编码。内容审核业务对应的场景代码。
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
