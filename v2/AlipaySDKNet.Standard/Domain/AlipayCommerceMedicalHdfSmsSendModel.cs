using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfSmsSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfSmsSendModel : AopObject
    {
        /// <summary>
        /// 短信平台的appid
        /// </summary>
        [XmlElement("sms_app_id")]
        public string SmsAppId { get; set; }

        /// <summary>
        /// 短信模版参数
        /// </summary>
        [XmlElement("template_args_str")]
        public string TemplateArgsStr { get; set; }

        /// <summary>
        /// 短信平台创建的模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 调用方传入的消息id
        /// </summary>
        [XmlElement("third_msg_id")]
        public string ThirdMsgId { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("to_account_no")]
        public string ToAccountNo { get; set; }
    }
}
