using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfcustomerCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSfcustomerCreateModel : AopObject
    {
        /// <summary>
        /// 客户BD工号
        /// </summary>
        [XmlElement("bd")]
        public string Bd { get; set; }

        /// <summary>
        /// 客户编码
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 行业
        /// </summary>
        [XmlElement("customer_industry")]
        public string CustomerIndustry { get; set; }

        /// <summary>
        /// 客户常用名
        /// </summary>
        [XmlElement("customer_short_name")]
        public string CustomerShortName { get; set; }

        /// <summary>
        /// 邓白氏编码
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// salesforce客户region
        /// </summary>
        [XmlElement("salesforce_region")]
        public string SalesforceRegion { get; set; }
    }
}
