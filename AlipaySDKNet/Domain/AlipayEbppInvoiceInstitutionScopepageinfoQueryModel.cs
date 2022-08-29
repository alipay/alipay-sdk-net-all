using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionScopepageinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceInstitutionScopepageinfoQueryModel : AopObject
    {
        /// <summary>
        /// 企业共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// EMPLOYEE（员工支付宝id）,ENTERPRISE_PAY_UID（员工企业码id）,PHONE（员工手机号) 默认返回员工id（支付宝id或企业码员工id），如需返回手机号需指定
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
