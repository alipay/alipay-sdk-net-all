using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainIdentityInfoCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainIdentityInfoCertifyModel : AopObject
    {
        /// <summary>
        /// 支付宝账户
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 系统业务编号
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务系统bizId
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 认证类型，PERSON：代表个人，ENTERPRISE：代表企业
        /// </summary>
        [XmlElement("certify_enum")]
        public string CertifyEnum { get; set; }

        /// <summary>
        /// 业务系统渠道名称
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ep_cert_name")]
        public string EpCertName { get; set; }

        /// <summary>
        /// 企业证件号码
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业证件号码类型
        /// </summary>
        [XmlElement("ep_cert_no_type")]
        public string EpCertNoType { get; set; }

        /// <summary>
        /// 法人证件名称
        /// </summary>
        [XmlElement("l_person_cert_name")]
        public string LPersonCertName { get; set; }

        /// <summary>
        /// 法人证件号码
        /// </summary>
        [XmlElement("l_person_cert_no")]
        public string LPersonCertNo { get; set; }

        /// <summary>
        /// 个人身份证件号码
        /// </summary>
        [XmlElement("l_person_certno_type")]
        public string LPersonCertnoType { get; set; }

        /// <summary>
        /// 系统操作名称
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 系统租户Id
        /// </summary>
        [XmlElement("owner_uid")]
        public string OwnerUid { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("person_cert_no")]
        public string PersonCertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("person_cert_type")]
        public string PersonCertType { get; set; }

        /// <summary>
        /// 个人名称
        /// </summary>
        [XmlElement("person_name")]
        public string PersonName { get; set; }
    }
}
