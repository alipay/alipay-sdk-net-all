using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsAssistantMsgContentVO Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsAssistantMsgContentVO : AopObject
    {
        /// <summary>
        /// 小助手商品活动列表
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("assistant_goods_v_o")]
        public List<AssistantGoodsVO> GoodsList { get; set; }

        /// <summary>
        /// 小助手定向消息内容，发送小助手时推送给用户的群内推荐内容
        /// </summary>
        [XmlElement("recommend_text")]
        public string RecommendText { get; set; }
    }
}
