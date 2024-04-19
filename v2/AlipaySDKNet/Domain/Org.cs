using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Org Data Structure.
    /// </summary>
    [Serializable]
    public class Org : AopObject
    {
        /// <summary>
        /// 企业证件号
        /// </summary>
        [XmlElement("org_id_number")]
        public string OrgIdNumber { get; set; }

        /// <summary>
        /// 企业证件类型，（证件号不为空时必填，详见企业证件类型）
        /// </summary>
        [XmlElement("org_id_type")]
        public string OrgIdType { get; set; }

        /// <summary>
        /// 法定代表人证件号
        /// </summary>
        [XmlElement("org_legal_id_number")]
        public string OrgLegalIdNumber { get; set; }

        /// <summary>
        /// 法定代表人证件类型
        /// </summary>
        [XmlElement("org_legal_id_type")]
        public string OrgLegalIdType { get; set; }

        /// <summary>
        /// 法定代表人名称
        /// </summary>
        [XmlElement("org_legal_name")]
        public string OrgLegalName { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 企业唯一标识：可传入平台机构id、企业证件号、企业邮箱等（个人用户与企业的唯一标识不可重复）
        /// </summary>
        [XmlElement("third_party_user_id")]
        public string ThirdPartyUserId { get; set; }
    }
}
