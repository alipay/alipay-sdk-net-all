using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenUserDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenUserDTO : AopObject
    {
        /// <summary>
        /// 证件名称
        /// </summary>
        [XmlElement("id_card_name")]
        public string IdCardName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 10身份证；22社会统一信用代码；55护照；23营业执照
        /// </summary>
        [XmlElement("id_card_type")]
        public long IdCardType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
