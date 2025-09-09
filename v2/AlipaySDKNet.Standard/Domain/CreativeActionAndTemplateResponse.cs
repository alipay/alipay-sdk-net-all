using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativeActionAndTemplateResponse Data Structure.
    /// </summary>
    [Serializable]
    public class CreativeActionAndTemplateResponse : AopObject
    {
        /// <summary>
        /// 当前创建创意时可选择的交互类型集合,会根据挂载单元查询出对应所有创意模版对应的可选交互类型集合信息
        /// </summary>
        [XmlArray("action_type_list")]
        [XmlArrayItem("string")]
        public List<string> ActionTypeList { get; set; }

        /// <summary>
        /// 创意模版信息
        /// </summary>
        [XmlElement("creative_template_resp")]
        public CreativeTemplateResp CreativeTemplateResp { get; set; }
    }
}
