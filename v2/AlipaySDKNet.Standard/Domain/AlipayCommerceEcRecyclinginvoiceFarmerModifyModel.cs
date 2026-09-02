using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceFarmerModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceFarmerModifyModel : AopObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 支付宝账号类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 归属承包主身份证号
        /// </summary>
        [XmlElement("belong_contractor_cert_no")]
        public string BelongContractorCertNo { get; set; }

        /// <summary>
        /// 归属家庭主身份证
        /// </summary>
        [XmlElement("belong_family_head_cert_no")]
        public string BelongFamilyHeadCertNo { get; set; }

        /// <summary>
        /// 农户ID
        /// </summary>
        [XmlElement("farmer_id")]
        public string FarmerId { get; set; }

        /// <summary>
        /// 农户姓名
        /// </summary>
        [XmlElement("farmer_name")]
        public string FarmerName { get; set; }

        /// <summary>
        /// 是否承包主
        /// </summary>
        [XmlElement("is_contractor")]
        public string IsContractor { get; set; }

        /// <summary>
        /// 是否家庭主
        /// </summary>
        [XmlElement("is_family_master")]
        public string IsFamilyMaster { get; set; }
    }
}
