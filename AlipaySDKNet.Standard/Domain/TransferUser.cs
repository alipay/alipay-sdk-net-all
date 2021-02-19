using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferUser Data Structure.
    /// </summary>
    [Serializable]
    public class TransferUser : AopObject
    {
        /// <summary>
        /// 生日
        /// </summary>
        [XmlElement("birth_date")]
        public string BirthDate { get; set; }

        /// <summary>
        /// 证件信息
        /// </summary>
        [XmlElement("credential")]
        public TransferCredential Credential { get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        [XmlElement("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 用户地址信息
        /// </summary>
        [XmlElement("user_address")]
        public TransferAddressInfo UserAddress { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        [XmlElement("user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名字信息
        /// </summary>
        [XmlElement("user_name")]
        public TransferUserName UserName { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("user_phone_no")]
        public string UserPhoneNo { get; set; }
    }
}
