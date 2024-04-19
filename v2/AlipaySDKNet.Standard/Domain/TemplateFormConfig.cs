using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateFormConfig Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateFormConfig : AopObject
    {
        /// <summary>
        /// 表单可选字段，required里面的选项与optional里面的选项不能存在重复
        /// </summary>
        [XmlElement("fields")]
        public TemplateFormFields Fields { get; set; }

        /// <summary>
        /// 入会时承接入会弹层的小程序appId
        /// </summary>
        [XmlElement("open_card_mini_app_id")]
        public string OpenCardMiniAppId { get; set; }
    }
}
