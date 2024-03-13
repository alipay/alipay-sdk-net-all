using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageTemplateModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMessageTemplateModifyModel : AopObject
    {
        /// <summary>
        /// 短信模板申请说明，是模板审核的参考信息之一。
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 签名名称。签名名称不区分大小写字母，如【Alipay】和【alipay】视为名称相同。
        /// </summary>
        [XmlElement("sign_name")]
        public string SignName { get; set; }

        /// <summary>
        /// 短信模板Code。
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        [XmlElement("template_content")]
        public string TemplateContent { get; set; }

        /// <summary>
        /// 模板名称。
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// 短信类型。取值： 0：验证码。 1：短信通知。 2：推广短信。 3：国际/港澳台消息。
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }
    }
}
