using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWaterUsertaskdetailBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceWaterUsertaskdetailBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("user_task_detail_response")]
        public List<UserTaskDetailResponse> DataList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
