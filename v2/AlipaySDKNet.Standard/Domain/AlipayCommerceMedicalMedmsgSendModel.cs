using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedmsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedmsgSendModel : AopObject
    {
        /// <summary>
        /// 来源业务
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 预期发送时间
        /// </summary>
        [XmlElement("expect_time")]
        public string ExpectTime { get; set; }

        /// <summary>
        /// 消息参数列表
        /// </summary>
        [XmlArray("msg_arg_list")]
        [XmlArrayItem("medical_medmsg_arg")]
        public List<MedicalMedmsgArg> MsgArgList { get; set; }

        /// <summary>
        /// 消息业务渠道
        /// </summary>
        [XmlElement("msg_channel")]
        public string MsgChannel { get; set; }

        /// <summary>
        /// 外部业务ID
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部消息id
        /// </summary>
        [XmlElement("out_msg_id")]
        public string OutMsgId { get; set; }

        /// <summary>
        /// 模板code
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 消息目标用户id
        /// </summary>
        [XmlElement("to_open_id")]
        public string ToOpenId { get; set; }

        /// <summary>
        /// 消息目标用户id
        /// </summary>
        [XmlElement("to_user_id")]
        public string ToUserId { get; set; }
    }
}
