using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayOrderQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpayOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 每页的条目数量
        /// </summary>
        [XmlElement("items_per_page")]
        public long ItemsPerPage { get; set; }

        /// <summary>
        /// 是否存在下一页数据
        /// </summary>
        [XmlElement("next_page")]
        public bool NextPage { get; set; }

        /// <summary>
        /// 订单列表
        /// </summary>
        [XmlArray("order_vo_list")]
        [XmlArrayItem("order_v_o")]
        public List<OrderVO> OrderVoList { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlArray("page")]
        [XmlArrayItem("number")]
        public List<long> Page { get; set; }
    }
}
