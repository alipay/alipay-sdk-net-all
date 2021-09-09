using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataBillBizfundagentQueryResponse.
    /// </summary>
    public class AlipayDataBillBizfundagentQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金明细记录
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("biz_fund_report_result")]
        public List<BizFundReportResult> DetailList { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 页面大小，最大2000
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 数据分页总页数
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
