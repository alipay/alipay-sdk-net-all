using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniActivityModuleQueryResponse.
    /// </summary>
    public class AlipayOpenMiniActivityModuleQueryResponse : AopResponse
    {
        /// <summary>
        /// 本次查询的页码
        /// </summary>
        [XmlElement("current_page_num")]
        public long CurrentPageNum { get; set; }

        /// <summary>
        /// 模块的数据项列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("mini_activity_module_query_info")]
        public List<MiniActivityModuleQueryInfo> Data { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("per_page_count")]
        public long PerPageCount { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 符合条件的总数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
