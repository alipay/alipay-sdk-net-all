using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIotfmPlugaddrQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIotfmPlugaddrQueryModel : AopObject
    {
        /// <summary>
        /// 主账户刷脸ftoken
        /// </summary>
        [XmlElement("ftoken")]
        public string Ftoken { get; set; }

        /// <summary>
        /// 主账户支付宝账号openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 主账户其他支付宝账号openid
        /// </summary>
        [XmlElement("other_open_id")]
        public string OtherOpenId { get; set; }

        /// <summary>
        /// 主账户其他支付宝账号uid
        /// </summary>
        [XmlElement("other_user_id")]
        public string OtherUserId { get; set; }

        /// <summary>
        /// 终端sn
        /// </summary>
        [XmlElement("term_sn")]
        public string TermSn { get; set; }

        /// <summary>
        /// 医保sn
        /// </summary>
        [XmlElement("tmnl_sn")]
        public string TmnlSn { get; set; }

        /// <summary>
        /// 主账户支付宝账号uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
