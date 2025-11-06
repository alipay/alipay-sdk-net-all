using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PolicyOrgHolderVO Data Structure.
    /// </summary>
    [Serializable]
    public class PolicyOrgHolderVO : AopObject
    {
        /// <summary>
        /// 枚举值： 统一社会信用代码:24
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 企业联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 企业联系人邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 单位性质为个体工商户时必传
        /// </summary>
        [XmlElement("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 投保单位名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 按产品决定是否必传
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 企业联系人电话
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }
    }
}
