using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSceneUserSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSceneUserSignModel : AopObject
    {
        /// <summary>
        /// 开通人绑定的支付宝openId
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝学校内标
        /// </summary>
        [XmlElement("alipay_school_id")]
        public string AlipaySchoolId { get; set; }

        /// <summary>
        /// 开通人绑定的支付宝UID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。{1:居民身份证；A:护照；X:学工号}
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 刷脸用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 平台来源标识（使用开放平台pid）
        /// </summary>
        [XmlElement("platform_channel")]
        public string PlatformChannel { get; set; }

        /// <summary>
        /// 二级渠道来源标识（使用渠道商的开放平台pid）
        /// </summary>
        [XmlElement("sub_channel")]
        public string SubChannel { get; set; }

        /// <summary>
        /// iot采脸流水id
        /// </summary>
        [XmlElement("zim_id")]
        public string ZimId { get; set; }
    }
}
