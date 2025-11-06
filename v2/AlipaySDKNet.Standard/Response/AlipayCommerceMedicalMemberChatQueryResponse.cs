using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMemberChatQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMemberChatQueryResponse : AopResponse
    {
        /// <summary>
        /// 头像地址
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 用户没有查看到的医生消息
        /// </summary>
        [XmlElement("doctor_message")]
        public long DoctorMessage { get; set; }

        /// <summary>
        /// 好大夫提供的客户与医生交流的页面地址
        /// </summary>
        [XmlElement("doctor_url")]
        public string DoctorUrl { get; set; }

        /// <summary>
        /// 健康师的昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 标语
        /// </summary>
        [XmlElement("slogan")]
        public string Slogan { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 未读消息数量
        /// </summary>
        [XmlElement("unread_message")]
        public long UnreadMessage { get; set; }
    }
}
