using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalNosubscribeMsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalNosubscribeMsgSendModel : AopObject
    {
        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝uid 2088开头的16位纯数字，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息;
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 消息参数列表
        /// </summary>
        [XmlArray("msg_arg_list")]
        [XmlArrayItem("medical_no_subscribe_msg_send_arg")]
        public List<MedicalNoSubscribeMsgSendArg> MsgArgList { get; set; }

        /// <summary>
        /// 外部消息id
        /// </summary>
        [XmlElement("out_msg_id")]
        public string OutMsgId { get; set; }

        /// <summary>
        /// 模板码，支付宝侧定义
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("user_card_no")]
        public string UserCardNo { get; set; }

        /// <summary>
        /// 用户证件类型 目前仅支持身份证
        /// </summary>
        [XmlElement("user_card_type")]
        public string UserCardType { get; set; }
    }
}
