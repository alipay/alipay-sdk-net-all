using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyIdentifyinfoInfoQueryResponse.
    /// </summary>
    public class AlipayUserCertifyIdentifyinfoInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 组织地址
        /// </summary>
        [XmlElement("org_address")]
        public string OrgAddress { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("org_cert_name")]
        public string OrgCertName { get; set; }

        /// <summary>
        /// 组织证件号码
        /// </summary>
        [XmlElement("org_cert_no")]
        public string OrgCertNo { get; set; }

        /// <summary>
        /// 组织证件类型
        /// </summary>
        [XmlElement("org_cert_type")]
        public string OrgCertType { get; set; }

        /// <summary>
        /// yyyyMMdd或者长期
        /// </summary>
        [XmlElement("org_expire_date")]
        public string OrgExpireDate { get; set; }

        /// <summary>
        /// 组织法人代表名字
        /// </summary>
        [XmlElement("org_legal_cert_name")]
        public string OrgLegalCertName { get; set; }

        /// <summary>
        /// 组织法人代表证件号码
        /// </summary>
        [XmlElement("org_legal_cert_no")]
        public string OrgLegalCertNo { get; set; }

        /// <summary>
        /// 组织法人代表证件类型
        /// </summary>
        [XmlElement("org_legal_cert_type")]
        public string OrgLegalCertType { get; set; }

        /// <summary>
        /// yyyyMMdd或者长期
        /// </summary>
        [XmlElement("org_legal_expire_date")]
        public string OrgLegalExpireDate { get; set; }

        /// <summary>
        /// 组织法人代表证件图片
        /// </summary>
        [XmlArray("org_legal_pictures")]
        [XmlArrayItem("string")]
        public List<string> OrgLegalPictures { get; set; }

        /// <summary>
        /// 组织证件图片
        /// </summary>
        [XmlArray("org_pictures")]
        [XmlArrayItem("string")]
        public List<string> OrgPictures { get; set; }

        /// <summary>
        /// 个人名称
        /// </summary>
        [XmlElement("person_cert_name")]
        public string PersonCertName { get; set; }

        /// <summary>
        /// 个人证件号码
        /// </summary>
        [XmlElement("person_cert_no")]
        public string PersonCertNo { get; set; }

        /// <summary>
        /// 个人证件类型
        /// </summary>
        [XmlElement("person_cert_type")]
        public string PersonCertType { get; set; }

        /// <summary>
        /// yyyyMMdd或者长期
        /// </summary>
        [XmlElement("person_expire_date")]
        public string PersonExpireDate { get; set; }

        /// <summary>
        /// 个人证件图片
        /// </summary>
        [XmlArray("person_pictures")]
        [XmlArrayItem("string")]
        public List<string> PersonPictures { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
