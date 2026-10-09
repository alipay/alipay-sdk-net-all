using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecipientInfoOrder Data Structure.
    /// </summary>
    [Serializable]
    public class RecipientInfoOrder : AopObject
    {
        /// <summary>
        /// 收件地址的详细地址，寄出纸质发票时方便快递员找到地府
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 购方的收件人的电子邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 购方的pid
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 购方收件人名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 购方收件人的手机号
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }
    }
}
