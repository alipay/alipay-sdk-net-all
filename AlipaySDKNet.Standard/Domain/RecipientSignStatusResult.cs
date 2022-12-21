using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecipientSignStatusResult Data Structure.
    /// </summary>
    [Serializable]
    public class RecipientSignStatusResult : AopObject
    {
        /// <summary>
        /// 创建理由
        /// </summary>
        [XmlElement("creation_reason")]
        public string CreationReason { get; set; }

        /// <summary>
        /// 驳回时间
        /// </summary>
        [XmlElement("declined_date_time")]
        public string DeclinedDateTime { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("declined_reason")]
        public string DeclinedReason { get; set; }

        /// <summary>
        /// 默认收件人
        /// </summary>
        [XmlElement("default_recipient")]
        public string DefaultRecipient { get; set; }

        /// <summary>
        /// 投递时间
        /// </summary>
        [XmlElement("delivered_date_time")]
        public string DeliveredDateTime { get; set; }

        /// <summary>
        /// 投递方式
        /// </summary>
        [XmlElement("delivery_method")]
        public string DeliveryMethod { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        [XmlElement("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 全名
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        [XmlElement("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 花名
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 注释、笔记
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 签署人类型
        /// </summary>
        [XmlElement("recipient_type")]
        public string RecipientType { get; set; }

        /// <summary>
        /// 签署顺序
        /// </summary>
        [XmlElement("routing_order")]
        public string RoutingOrder { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        [XmlElement("sent_date_time")]
        public string SentDateTime { get; set; }

        /// <summary>
        /// docusign账号
        /// </summary>
        [XmlElement("sign_account_no")]
        public string SignAccountNo { get; set; }

        /// <summary>
        /// 签署时间
        /// </summary>
        [XmlElement("signed_date_time")]
        public string SignedDateTime { get; set; }

        /// <summary>
        /// 签署状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 状态编码
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
