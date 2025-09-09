using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddCategoryBatchitemQueryResponse.
    /// </summary>
    public class AlipayOfflineSmddCategoryBatchitemQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_bean")]
        public List<ItemBean> ItemList { get; set; }
    }
}
