using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppUnishopItemlistQueryResponse.
    /// </summary>
    public class AlipayOpenAppUnishopItemlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 团购门店id
        /// </summary>
        [XmlElement("a_shop_id")]
        public string AShopId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("a_shop_item_v_o")]
        public List<AShopItemVO> ItemList { get; set; }

        /// <summary>
        /// 商品总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
