using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinInsuranceReportQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinInsuranceReportQueryResponse : AopResponse
    {
        /// <summary>
        /// 个性化参数
        /// </summary>
        [XmlElement("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 案件信息列表
        /// </summary>
        [XmlArray("report_info_list")]
        [XmlArrayItem("report_info")]
        public List<ReportInfo> ReportInfoList { get; set; }

        /// <summary>
        /// 请求交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
