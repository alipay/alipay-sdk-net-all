using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMessageSendModel : AopObject
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 接收短信的手机号码。手机号码格式：  国内短信：+/+86/0086/86或无任何前缀的11位手机号码，例如1590000****。 国际/港澳台消息：国际区号+号码，例如852000012****。 说明 验证码类型短信，建议使用接口SendSms单独发送。
        /// </summary>
        [XmlArray("phone_number")]
        [XmlArrayItem("string")]
        public List<string> PhoneNumber { get; set; }

        /// <summary>
        /// 无特殊需要可忽略此字段。
        /// </summary>
        [XmlArray("sms_up_extend_code")]
        [XmlArrayItem("string")]
        public List<string> SmsUpExtendCode { get; set; }

        /// <summary>
        /// 短信模板名称
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 短信模板变量对应的实际值。该数组中每个对象需和phone_number中的手机号一一对应。模板中的多个变量用 "#" 区分；"="左边为变量名，"="右边为变量值。 当前字段已废弃(拼接有缺陷，调整为json string 参数)
        /// </summary>
        [XmlArray("template_param")]
        [XmlArrayItem("string")]
        public List<string> TemplateParam { get; set; }

        /// <summary>
        /// 短信模板变量对应的实际值。
        /// </summary>
        [XmlElement("template_param_json")]
        public string TemplateParamJson { get; set; }
    }
}
