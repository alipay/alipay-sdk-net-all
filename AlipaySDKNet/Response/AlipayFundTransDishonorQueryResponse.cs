using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransDishonorQueryResponse.
    /// </summary>
    public class AlipayFundTransDishonorQueryResponse : AopResponse
    {
        /// <summary>
        /// 退票订单详细列表：可能包含多个退票订单信息。如items值为0,则此参数不返回。
        /// </summary>
        [XmlArray("dishonor_order_list")]
        [XmlArrayItem("dishonor_order")]
        public List<DishonorOrder> DishonorOrderList { get; set; }

        /// <summary>
        /// 符合条件总记录数：大于等于0。
        /// </summary>
        [XmlElement("items")]
        public string Items { get; set; }

        /// <summary>
        /// 每页记录数：大于等于1
        /// </summary>
        [XmlElement("items_per_page")]
        public string ItemsPerPage { get; set; }

        /// <summary>
        /// 查询页号：大于等于1
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }
    }
}
