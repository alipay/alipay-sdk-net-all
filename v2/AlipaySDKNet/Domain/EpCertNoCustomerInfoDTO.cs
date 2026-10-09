using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpCertNoCustomerInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EpCertNoCustomerInfoDTO : AopObject
    {
        /// <summary>
        /// 客户编码
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 客户常用名
        /// </summary>
        [XmlElement("customer_short_name")]
        public string CustomerShortName { get; set; }

        /// <summary>
        /// 社会统一信用代码
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }
    }
}
