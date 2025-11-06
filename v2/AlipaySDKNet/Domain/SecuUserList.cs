using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SecuUserList Data Structure.
    /// </summary>
    [Serializable]
    public class SecuUserList : AopObject
    {
        /// <summary>
        /// 用户签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 用户头像地址
        /// </summary>
        [XmlElement("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 0男 1女 2未知
        /// </summary>
        [XmlElement("gender")]
        public long Gender { get; set; }

        /// <summary>
        /// 用户投资宣言
        /// </summary>
        [XmlElement("motto")]
        public string Motto { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }
    }
}
