using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyBizflowBatchqueryResponse.
    /// </summary>
    public class MybankEcnyBizflowBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("biz_flow_info")]
        public List<BizFlowInfo> DataList { get; set; }

        /// <summary>
        /// 第一次查询为空，翻页查询取最后条记录的FlowNo
        /// </summary>
        [XmlElement("next_cursor")]
        public string NextCursor { get; set; }

        /// <summary>
        /// 每页数量为10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
