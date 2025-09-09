using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMessageNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMessageNotifyModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 预期发送时间，不填默认即时发送
        /// </summary>
        [XmlElement("expect_time")]
        public string ExpectTime { get; set; }

        /// <summary>
        /// 医疗场景小程序消息发送参数
        /// </summary>
        [XmlArray("msg_arg_list")]
        [XmlArrayItem("medical_medmsg_arg")]
        public List<MedicalMedmsgArg> MsgArgList { get; set; }

        /// <summary>
        /// 外部消息id，保持幂等
        /// </summary>
        [XmlElement("out_msg_id")]
        public string OutMsgId { get; set; }

        /// <summary>
        /// 发送消息的模板code
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 接收人的支付宝用户openID
        /// </summary>
        [XmlElement("to_open_id")]
        public string ToOpenId { get; set; }

        /// <summary>
        /// 接收人的支付宝用户ID
        /// </summary>
        [XmlElement("to_user_id")]
        public string ToUserId { get; set; }
    }
}
