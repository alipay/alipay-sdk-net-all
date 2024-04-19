using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolMessageQueryResponse.
    /// </summary>
    public class AlipayCommerceIotSdarttoolMessageQueryResponse : AopResponse
    {
        /// <summary>
        /// 消息消费返回码，不用的消息类型返回码不一样
        /// </summary>
        [XmlElement("consume_err_code")]
        public string ConsumeErrCode { get; set; }

        /// <summary>
        /// 消息消费错误原因
        /// </summary>
        [XmlElement("consume_err_msg")]
        public string ConsumeErrMsg { get; set; }

        /// <summary>
        /// 消息消费状态1-未消费; 2-消费成功；3-消费失败
        /// </summary>
        [XmlElement("consume_state")]
        public long ConsumeState { get; set; }

        /// <summary>
        /// 消息投递次数
        /// </summary>
        [XmlElement("deliver_cnt")]
        public long DeliverCnt { get; set; }

        /// <summary>
        /// 消息投递状态 1: 未投递 2: 投递中 3: 投递成功 4: 投递失败 5: 消息失效不再发送
        /// </summary>
        [XmlElement("deliver_status")]
        public string DeliverStatus { get; set; }

        /// <summary>
        /// 消息最后一次发送时间
        /// </summary>
        [XmlElement("last_deliver_at")]
        public long LastDeliverAt { get; set; }

        /// <summary>
        /// 消息确认消费时间(ms)
        /// </summary>
        [XmlElement("msg_ack_time")]
        public long MsgAckTime { get; set; }

        /// <summary>
        /// 消息必达类型 1-非必达; 2-必达.
        /// </summary>
        [XmlElement("msg_bida")]
        public long MsgBida { get; set; }

        /// <summary>
        /// 消息过期时间(ms)
        /// </summary>
        [XmlElement("msg_expire_time")]
        public long MsgExpireTime { get; set; }

        /// <summary>
        /// 消息创建时间(ms)
        /// </summary>
        [XmlElement("msg_gmt_create")]
        public long MsgGmtCreate { get; set; }

        /// <summary>
        /// 消息投递优先级
        /// </summary>
        [XmlElement("msg_priority")]
        public long MsgPriority { get; set; }
    }
}
