using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthArchiveDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthArchiveDeleteModel : AopObject
    {
        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 档案ID、报告ID、药盒识别ID
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 类型编码
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 会话SessionId
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 填写号码
        /// </summary>
        [XmlElement("user_card_no")]
        public string UserCardNo { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        [XmlElement("user_cert_type")]
        public string UserCertType { get; set; }

        /// <summary>
        /// 取当前会话的用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
