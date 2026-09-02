using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMsgReachSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMsgReachSendModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 用户OPENID
        /// </summary>
        [XmlElement("alipay_user_open_id")]
        public string AlipayUserOpenId { get; set; }

        /// <summary>
        /// 业务来源标识
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 消息模版code，业务方提供
        /// </summary>
        [XmlElement("msg_template_code")]
        public string MsgTemplateCode { get; set; }

        /// <summary>
        /// 幂等键
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// Push推送渠道参数
        /// </summary>
        [XmlElement("push_channel")]
        public PushChannelDTO PushChannel { get; set; }
    }
}
