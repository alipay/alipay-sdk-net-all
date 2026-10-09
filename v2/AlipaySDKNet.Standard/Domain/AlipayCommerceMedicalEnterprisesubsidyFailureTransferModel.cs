using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalEnterprisesubsidyFailureTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalEnterprisesubsidyFailureTransferModel : AopObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 企业编号
        /// </summary>
        [XmlElement("cur_company_id")]
        public string CurCompanyId { get; set; }

        /// <summary>
        /// 上级企业编号
        /// </summary>
        [XmlElement("father_company_id")]
        public string FatherCompanyId { get; set; }

        /// <summary>
        /// 就诊编号
        /// </summary>
        [XmlElement("mdtrt_id")]
        public string MdtrtId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 医保结算编号
        /// </summary>
        [XmlElement("setl_id")]
        public string SetlId { get; set; }
    }
}
