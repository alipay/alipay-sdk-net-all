using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepAnnualReportInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepAnnualReportInfo : AopObject
    {
        /// <summary>
        /// 企业工商年报基本信息
        /// </summary>
        [XmlElement("basic_info")]
        public ZmepAnnualReportBasicInfo BasicInfo { get; set; }

        /// <summary>
        /// 对外投资信息
        /// </summary>
        [XmlElement("invest_list")]
        public ZmepAnnualReportInvestInfo InvestList { get; set; }

        /// <summary>
        /// 发布日期
        /// </summary>
        [XmlElement("public_date")]
        public string PublicDate { get; set; }

        /// <summary>
        /// 报送年度
        /// </summary>
        [XmlElement("report_year")]
        public string ReportYear { get; set; }

        /// <summary>
        /// 股东及出资信息
        /// </summary>
        [XmlArray("shareholder_list")]
        [XmlArrayItem("zmep_annual_report_shareholder_info")]
        public List<ZmepAnnualReportShareholderInfo> ShareholderList { get; set; }

        /// <summary>
        /// 企业工商年报网站信息
        /// </summary>
        [XmlArray("website_list")]
        [XmlArrayItem("zmep_annual_report_website_info")]
        public List<ZmepAnnualReportWebsiteInfo> WebsiteList { get; set; }
    }
}
