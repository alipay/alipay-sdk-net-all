using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRentSignSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRentSignSyncModel : AopObject
    {
        /// <summary>
        /// 用户证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 企业方调用时，必传数据
        /// </summary>
        [XmlElement("enterprise_credit_no")]
        public string EnterpriseCreditNo { get; set; }

        /// <summary>
        /// 公积金中心分配的租赁企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 公积金中心调用时，必传企业唯一标识
        /// </summary>
        [XmlElement("enterprise_no")]
        public string EnterpriseNo { get; set; }

        /// <summary>
        /// 公积金中心分配的租赁企业凭证
        /// </summary>
        [XmlElement("enterprise_proof")]
        public string EnterpriseProof { get; set; }

        /// <summary>
        /// 公积金中心编码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 用户签约状态
        /// </summary>
        [XmlElement("rent_sign_status")]
        public string RentSignStatus { get; set; }

        /// <summary>
        /// 新用户签约时传签约（SIGNED）；老用户按实际办理状态传对应状态
        /// </summary>
        [XmlElement("rent_sign_type")]
        public string RentSignType { get; set; }

        /// <summary>
        /// 公积金中心
        /// </summary>
        [XmlElement("request_party")]
        public string RequestParty { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 签约用户在公积金侧的备案编号
        /// </summary>
        [XmlElement("user_record_no")]
        public string UserRecordNo { get; set; }
    }
}
