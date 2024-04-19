using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SmsReport Data Structure.
    /// </summary>
    [Serializable]
    public class SmsReport : AopObject
    {
        /// <summary>
        /// 内部回执id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误码信息描述。
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 短信发送时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 短信长度
        /// </summary>
        [XmlElement("sms_size")]
        public string SmsSize { get; set; }

        /// <summary>
        /// 是否发送成功。取值： true：发送成功。 false：发送失败。
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
