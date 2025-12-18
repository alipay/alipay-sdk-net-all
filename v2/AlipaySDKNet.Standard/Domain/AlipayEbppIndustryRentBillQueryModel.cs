using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRentBillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRentBillQueryModel : AopObject
    {
        /// <summary>
        /// 用户证件号码
        /// </summary>
        [XmlElement("cert_num")]
        public string CertNum { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 企业信用代码
        /// </summary>
        [XmlElement("enterprise_credit_no")]
        public string EnterpriseCreditNo { get; set; }

        /// <summary>
        ///   公积金中心分配的租赁企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

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
        /// 开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
