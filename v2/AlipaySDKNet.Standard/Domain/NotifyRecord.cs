using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NotifyRecord Data Structure.
    /// </summary>
    [Serializable]
    public class NotifyRecord : AopObject
    {
        /// <summary>
        /// 通话的唯一ID
        /// </summary>
        [XmlElement("acid")]
        public string Acid { get; set; }

        /// <summary>
        /// 关联数据表单编码
        /// </summary>
        [XmlElement("belong_data_code")]
        public string BelongDataCode { get; set; }

        /// <summary>
        /// 关联数据ID
        /// </summary>
        [XmlElement("belong_data_id")]
        public string BelongDataId { get; set; }

        /// <summary>
        /// 发送内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 接收方
        /// </summary>
        [XmlElement("receiver")]
        public string Receiver { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 字段透传
        /// </summary>
        [XmlElement("send_type")]
        public string SendType { get; set; }

        /// <summary>
        /// 发送方
        /// </summary>
        [XmlElement("sender")]
        public string Sender { get; set; }

        /// <summary>
        /// 任务编码
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }
    }
}
