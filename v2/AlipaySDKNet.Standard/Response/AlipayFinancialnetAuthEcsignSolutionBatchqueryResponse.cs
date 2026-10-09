using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignSolutionBatchqueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignSolutionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 页，默认1，必须要大于0。
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页面大小，默认10。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 解决方案列表
        /// </summary>
        [XmlArray("solution_list")]
        [XmlArrayItem("solution_open_v_o")]
        public List<SolutionOpenVO> SolutionList { get; set; }

        /// <summary>
        /// 列表记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
