using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpRelatedPerformanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpRelatedPerformanceQueryModel : AopObject
    {
        /// <summary>
        /// 企业标识（统一信用代码/注册号/企业名）
        /// </summary>
        [XmlElement("company_key")]
        public string CompanyKey { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 人员证件号
        /// </summary>
        [XmlElement("ry_cert_no")]
        public string RyCertNo { get; set; }

        /// <summary>
        /// 人员姓名
        /// </summary>
        [XmlElement("ry_name")]
        public string RyName { get; set; }
    }
}
