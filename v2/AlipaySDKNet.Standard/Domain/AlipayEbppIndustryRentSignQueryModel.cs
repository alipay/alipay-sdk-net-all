using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRentSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRentSignQueryModel : AopObject
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
        /// 默认zf
        /// </summary>
        [XmlElement("draw_item")]
        public string DrawItem { get; set; }

        /// <summary>
        /// 企业信用代码
        /// </summary>
        [XmlElement("enterprise_credit_no")]
        public string EnterpriseCreditNo { get; set; }

        /// <summary>
        /// 公积金中心分配的租赁企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 公积金中心分配的租赁企业凭证
        /// </summary>
        [XmlElement("enterprise_proof")]
        public string EnterpriseProof { get; set; }

        /// <summary>
        /// 默认10启用
        /// </summary>
        [XmlElement("is_available")]
        public string IsAvailable { get; set; }

        /// <summary>
        /// 60-正常使用
        /// </summary>
        [XmlElement("online_state")]
        public string OnlineState { get; set; }

        /// <summary>
        /// 公积金中心编号
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
