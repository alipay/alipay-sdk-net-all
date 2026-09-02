using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserUgshoppingRecommendQueryResponse.
    /// </summary>
    public class AlipayUserUgshoppingRecommendQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_cards")]
        [XmlArrayItem("item_card_openapi")]
        public List<ItemCardOpenapi> ItemCards { get; set; }

        /// <summary>
        /// 下一页(到底时返回0)
        /// </summary>
        [XmlElement("next_page_num")]
        public long NextPageNum { get; set; }
    }
}
