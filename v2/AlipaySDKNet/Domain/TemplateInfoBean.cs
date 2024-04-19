using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateInfoBean Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateInfoBean : AopObject
    {
        /// <summary>
        /// 模板填充项，根据组件key值传入填写内容
        /// </summary>
        [XmlArray("fill_contents")]
        [XmlArrayItem("fill_content")]
        public List<FillContent> FillContents { get; set; }

        /// <summary>
        /// 签署文件名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 签署区，根据签署区key值传入对应的签署人信息
        /// </summary>
        [XmlArray("signfields")]
        [XmlArrayItem("sign_field_bean")]
        public List<SignFieldBean> Signfields { get; set; }

        /// <summary>
        /// 模板id，通过创建合同模板获取
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
