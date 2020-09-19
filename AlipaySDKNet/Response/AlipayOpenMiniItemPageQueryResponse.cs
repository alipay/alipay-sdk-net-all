using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniItemPageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniItemPageQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page_num")]
        public long CurrentPageNum { get; set; }

        /// <summary>
        /// 小程序商品列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("item_v_o")]
        public List<ItemVO> DataList { get; set; }

        /// <summary>
        /// 每页项数
        /// </summary>
        [XmlElement("per_page_count")]
        public long PerPageCount { get; set; }

        /// <summary>
        /// 总共项数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
