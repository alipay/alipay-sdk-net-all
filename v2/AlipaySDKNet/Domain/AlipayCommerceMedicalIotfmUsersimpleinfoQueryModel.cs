using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIotfmUsersimpleinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIotfmUsersimpleinfoQueryModel : AopObject
    {
        /// <summary>
        /// 插件访问令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 设备所在城市编码
        /// </summary>
        [XmlElement("device_city_code")]
        public string DeviceCityCode { get; set; }

        /// <summary>
        /// 子账户机构医保电子卡号
        /// </summary>
        [XmlElement("fm_ins_card_id")]
        public string FmInsCardId { get; set; }

        /// <summary>
        /// 主账户刷脸ftoken
        /// </summary>
        [XmlElement("ftoken")]
        public string Ftoken { get; set; }

        /// <summary>
        /// 主账户支付宝用户openid
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
        /// 主账户支付宝用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
