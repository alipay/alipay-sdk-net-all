using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsPerson Data Structure.
    /// </summary>
    [Serializable]
    public class InsPerson : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 干系人地址区县编码
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 投保参数;标准json格式
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 证件生效日期，提供给银保监会用于实名查验，"yyyy-mm-dd"格式
        /// </summary>
        [XmlElement("cert_effective_date")]
        public string CertEffectiveDate { get; set; }

        /// <summary>
        /// 证件失效日期，提供给银保监会用于实名查验，"yyyy-mm-dd"格式，若超过或等于2999-01-01代表长期生效
        /// </summary>
        [XmlElement("cert_expiration_date")]
        public string CertExpirationDate { get; set; }

        /// <summary>
        /// 证件上名称;如果渠道账号字段没填则必填
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码;如果渠道账号字段没填则必填
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型;如果渠道账号字段没填则必填   100:居民身份证;102:护照;103:军官证;104:士兵证;105:港澳居民往来内地通行证;106:台湾同胞往来大陆通行证;109:警官证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 渠道账号对应的uid;如果证件类型字段没填则必填
        /// </summary>
        [XmlElement("channel_user_id")]
        public string ChannelUserId { get; set; }

        /// <summary>
        /// channel_user_id为支付宝id时对应的openid
        /// </summary>
        [XmlElement("channel_user_open_id")]
        public string ChannelUserOpenId { get; set; }

        /// <summary>
        /// 渠道账号来源;1:支付宝账号 2:淘宝账号;如果证件类型字段没填则必填
        /// </summary>
        [XmlElement("channel_user_source")]
        public string ChannelUserSource { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 性别;M:男 F:女
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 1:卖家；2:支付人;
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        [XmlElement("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// user_id为支付宝id时对应的openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 张三
        /// </summary>
        [XmlElement("pronounce_name")]
        public string PronounceName { get; set; }

        /// <summary>
        /// 支付宝会员ID;如果是投保人则必填
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
