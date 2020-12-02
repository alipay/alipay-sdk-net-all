using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniShopRelationQueryResponse.
    /// </summary>
    public class AlipayOpenMiniShopRelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page_num")]
        public long CurrentPageNum { get; set; }

        /// <summary>
        /// 小程序门店绑定关系列表，principal_id为小程序id，entity_id为门店id
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("mini_entity_bind_v_o")]
        public List<MiniEntityBindVO> DataList { get; set; }

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
