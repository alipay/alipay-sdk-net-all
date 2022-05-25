using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApplyAttatchmentVO Data Structure.
    /// </summary>
    [Serializable]
    public class ApplyAttatchmentVO : AopObject
    {
        /// <summary>
        /// 保函开立申请书
        /// </summary>
        [XmlElement("apply_doc")]
        public string ApplyDoc { get; set; }

        /// <summary>
        /// 征信授权
        /// </summary>
        [XmlElement("auth_docs")]
        public string AuthDocs { get; set; }

        /// <summary>
        /// 投标书
        /// </summary>
        [XmlElement("bid_doc")]
        public string BidDoc { get; set; }

        /// <summary>
        /// 企业营业执照
        /// </summary>
        [XmlElement("business_licenses")]
        public string BusinessLicenses { get; set; }

        /// <summary>
        /// 企业证件信息
        /// </summary>
        [XmlElement("corporation_cert")]
        public string CorporationCert { get; set; }

        /// <summary>
        /// 开立保函担保公司委托合同
        /// </summary>
        [XmlElement("entrust_doc")]
        public string EntrustDoc { get; set; }

        /// <summary>
        /// 法人证件信息
        /// </summary>
        [XmlElement("legal_person_cert")]
        public string LegalPersonCert { get; set; }
    }
}
