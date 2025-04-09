using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddRecommendItemQueryResponse.
    /// </summary>
    public class AlipayOfflineSmddRecommendItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品对象
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_bean")]
        public List<ItemBean> ItemList { get; set; }
    }
}
