using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepAnnualReportInvestInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepAnnualReportInvestInfo : AopObject
    {
        /// <summary>
        /// 注册号/统一社会信用代码
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 投资设立企业或购买股权企业名称
        /// </summary>
        [XmlElement("invest_ep_name")]
        public string InvestEpName { get; set; }
    }
}
