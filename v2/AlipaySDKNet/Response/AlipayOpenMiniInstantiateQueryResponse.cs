using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInstantiateQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInstantiateQueryResponse : AopResponse
    {
        /// <summary>
        /// 实例化商家小程序列表
        /// </summary>
        [XmlArray("instantiate_list")]
        [XmlArrayItem("mini_instantiate_info")]
        public List<MiniInstantiateInfo> InstantiateList { get; set; }

        /// <summary>
        /// 分页页数
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }
    }
}
