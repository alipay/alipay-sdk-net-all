using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCoOverviewQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCoOverviewQueryModel : AopObject
    {
        /// <summary>
        /// 企业注册号或统一社会信用代码
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
