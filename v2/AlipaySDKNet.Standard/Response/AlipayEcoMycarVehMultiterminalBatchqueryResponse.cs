using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarVehMultiterminalBatchqueryResponse.
    /// </summary>
    public class AlipayEcoMycarVehMultiterminalBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 搜索结果
        /// </summary>
        [XmlArray("search_list")]
        [XmlArrayItem("veh_search_item")]
        public List<VehSearchItem> SearchList { get; set; }

        /// <summary>
        /// 总页码
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 数据总量
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
