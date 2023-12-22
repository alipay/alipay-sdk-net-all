using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalSubscribemsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalSubscribemsgSendModel : AopObject
    {
        /// <summary>
        /// 消息参数列表
        /// </summary>
        [XmlArray("msg_arg_list")]
        [XmlArrayItem("medical_subscribe_msg_send_arg")]
        public List<MedicalSubscribeMsgSendArg> MsgArgList { get; set; }

        /// <summary>
        /// 外部自身的消息id
        /// </summary>
        [XmlElement("out_msg_id")]
        public string OutMsgId { get; set; }

        /// <summary>
        /// 消息模板码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 支付宝用户open_id
        /// </summary>
        [XmlElement("to_open_id")]
        public string ToOpenId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("to_user_id")]
        public string ToUserId { get; set; }
    }
}
