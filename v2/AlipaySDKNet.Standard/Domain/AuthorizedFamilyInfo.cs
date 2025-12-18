using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthorizedFamilyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AuthorizedFamilyInfo : AopObject
    {
        /// <summary>
        /// 已授权家人证件号
        /// </summary>
        [XmlElement("user_cert_no")]
        public string UserCertNo { get; set; }

        /// <summary>
        /// 已授权家人证件类型
        /// </summary>
        [XmlElement("user_cert_type")]
        public string UserCertType { get; set; }

        /// <summary>
        /// 已授权家人跟支付宝用户本人的亲属关系
        /// </summary>
        [XmlElement("user_relation_type")]
        public string UserRelationType { get; set; }

        /// <summary>
        /// 已授权家人姓名
        /// </summary>
        [XmlElement("username")]
        public string Username { get; set; }
    }
}
