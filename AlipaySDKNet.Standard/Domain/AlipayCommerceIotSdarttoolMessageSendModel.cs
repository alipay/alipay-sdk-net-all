using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolMessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotSdarttoolMessageSendModel : AopObject
    {
        /// <summary>
        /// 当离线消息挤压太多时，若设备上线将获取所有未过期的消息。推送太多消息对设备体验不太好，所以此字段用于设置消息是必达。当消息不是必达的
        /// </summary>
        [XmlElement("bi_da")]
        public bool BiDa { get; set; }

        /// <summary>
        /// 设备查询条件类型 supplierid+sn : (SUPPLIERID_SN) itemid + sn: ITEMID_SN
        /// </summary>
        [XmlElement("device_query_type")]
        public string DeviceQueryType { get; set; }

        /// <summary>
        /// 是否即时消息; true-校验设备是否在线，false-不校验设备是否在线
        /// </summary>
        [XmlElement("immediate_msg")]
        public bool ImmediateMsg { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 根据消息类型有不同的消息模板，传入的消息内容会是多个参数如云打印 {"contentParams":["打印内容"],"target":"打印编号-可选默认第一个","instructionFormat":"template或cmd"} cloud_print: 消息内容详见: https://alipay.open.taobao.com/docs/doc.htm?spm=a219a.7629140.0.0.46cf4b70bQj0aZ&treeId=662&articleId=117980&docType=1#s1
        /// </summary>
        [XmlElement("msg_content")]
        public string MsgContent { get; set; }

        /// <summary>
        /// 消息内容格式
        /// </summary>
        [XmlElement("msg_content_type")]
        public string MsgContentType { get; set; }

        /// <summary>
        /// 消息过期时间戳(单位秒)， 默认为当前时间延期3天有效。若消息在此时间之前未推送，将不再推送（必达消息会永久保留直到推送成功）
        /// </summary>
        [XmlElement("msg_expire")]
        public long MsgExpire { get; set; }

        /// <summary>
        /// 离线消息，当设备在线时消息优先发送级别，越大优先级域高(优先级为正整数)。
        /// </summary>
        [XmlElement("msg_priority")]
        public long MsgPriority { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 服务ID，当小程序消费消息时必传(传入的是小程序ID)
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 厂商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
