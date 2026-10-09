using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PageTemplateParamInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PageTemplateParamInfoDTO : AopObject
    {
        /// <summary>
        /// 是否允许用户输入
        /// </summary>
        [XmlElement("allow_user_input")]
        public bool AllowUserInput { get; set; }

        /// <summary>
        /// code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 额外信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 前端需要的渲染类型
        /// </summary>
        [XmlElement("front_render_type")]
        public string FrontRenderType { get; set; }

        /// <summary>
        /// 表单的标题
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 是否为必填
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }

        /// <summary>
        /// type
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 填入值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
