using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiveInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiveInfoVO : AopObject
    {
        /// <summary>
        /// 邮寄地址。专票必传
        /// </summary>
        [XmlElement("mail_address")]
        public string MailAddress { get; set; }

        /// <summary>
        /// 收件人姓名。专票时必传
        /// </summary>
        [XmlElement("mail_name")]
        public string MailName { get; set; }

        /// <summary>
        /// 收件人手机号。专票时必填
        /// </summary>
        [XmlElement("mail_phone")]
        public string MailPhone { get; set; }

        /// <summary>
        /// 邮箱地址。接收电子发票时必传
        /// </summary>
        [XmlElement("receive_email")]
        public string ReceiveEmail { get; set; }
    }
}
