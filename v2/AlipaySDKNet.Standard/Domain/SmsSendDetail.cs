using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SmsSendDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SmsSendDetail : AopObject
    {
        /// <summary>
        /// 短信内容。
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 接收短信的手机号码
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 短信发送时间
        /// </summary>
        [XmlElement("send_date")]
        public string SendDate { get; set; }

        /// <summary>
        /// 运营商短信状态码。
        /// </summary>
        [XmlElement("sms_code")]
        public string SmsCode { get; set; }

        /// <summary>
        /// 短信发送结果说明
        /// </summary>
        [XmlElement("sms_desc")]
        public string SmsDesc { get; set; }

        /// <summary>
        /// 短信模板
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
