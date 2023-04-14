using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SummaryBillPageOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SummaryBillPageOpenApiDTO : AopObject
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("current_page")]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 汇总账单信息openapi
        /// </summary>
        [XmlArray("datas")]
        [XmlArrayItem("summary_bill_open_api_d_t_o")]
        public List<SummaryBillOpenApiDTO> Datas { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
