using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateMpcpromoItemQueryResponse.
    /// </summary>
    public class TechriskInnovateMpcpromoItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品推荐查询结果
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_query_info")]
        public List<ItemQueryInfo> ItemList { get; set; }

        /// <summary>
        /// 推荐请求的标识id，用于关联推荐结果和用户行为
        /// </summary>
        [XmlElement("recommend_id")]
        public string RecommendId { get; set; }
    }
}
