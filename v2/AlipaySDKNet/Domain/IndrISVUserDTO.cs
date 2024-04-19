using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrISVUserDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrISVUserDTO : AopObject
    {
        /// <summary>
        /// 地址信息
        /// </summary>
        [XmlElement("address")]
        public IndrISVAddressDTO Address { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 名字拼音
        /// </summary>
        [XmlElement("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 全名(英文或者拼音)
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 证件号（身份证号， 固定18位或15位）
        /// </summary>
        [XmlElement("identity_card_number")]
        public string IdentityCardNumber { get; set; }

        /// <summary>
        /// 证件类型：ID_CARD,PASSPORT
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 姓氏拼音
        /// </summary>
        [XmlElement("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 中文姓名，UTF8编码
        /// </summary>
        [XmlElement("native_full_name")]
        public string NativeFullName { get; set; }

        /// <summary>
        /// 区号
        /// </summary>
        [XmlElement("phone_area_code")]
        public string PhoneAreaCode { get; set; }

        /// <summary>
        /// 电话的二位国家码
        /// </summary>
        [XmlElement("phone_country")]
        public string PhoneCountry { get; set; }

        /// <summary>
        /// 手机号， 手机号 比如：13283491863（不含区号）
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
