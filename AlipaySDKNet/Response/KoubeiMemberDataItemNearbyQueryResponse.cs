using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMemberDataItemNearbyQueryResponse.
    /// </summary>
    public class KoubeiMemberDataItemNearbyQueryResponse : AopResponse
    {
        /// <summary>
        /// 附近优惠商品列表,前端根据其中的字段展示即可
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("nearby_goods")]
        public List<NearbyGoods> GoodsList { get; set; }

        /// <summary>
        /// 是否有下一页,用于分页展示
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 下页数据开始索引，请求下一页时作为请求参数start上传。
        /// </summary>
        [XmlElement("next_start")]
        public long NextStart { get; set; }
    }
}
