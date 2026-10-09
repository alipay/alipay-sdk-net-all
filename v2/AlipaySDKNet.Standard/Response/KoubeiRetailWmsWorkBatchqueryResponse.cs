using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsWorkBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsWorkBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询条件下作业总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 作业列表
        /// </summary>
        [XmlArray("work_list")]
        [XmlArrayItem("work_list_v_o")]
        public List<WorkListVO> WorkList { get; set; }
    }
}
