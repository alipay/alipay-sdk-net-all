using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiRepaynotifyConsultResponse.
    /// </summary>
    public class AlipayPcreditHuabeiRepaynotifyConsultResponse : AopResponse
    {
        /// <summary>
        /// 咨询编号
        /// </summary>
        [XmlElement("consult_code")]
        public string ConsultCode { get; set; }

        /// <summary>
        /// true表示打电话
        /// </summary>
        [XmlElement("do_call")]
        public bool DoCall { get; set; }

        /// <summary>
        /// 手机号用于打电话用
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Y-执行重试
        /// </summary>
        [XmlElement("re_consult")]
        public string ReConsult { get; set; }

        /// <summary>
        /// 校验不通过原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }

        /// <summary>
        /// 语音包code，用于拨打电话时使用的语音
        /// </summary>
        [XmlElement("voice_code")]
        public string VoiceCode { get; set; }
    }
}
