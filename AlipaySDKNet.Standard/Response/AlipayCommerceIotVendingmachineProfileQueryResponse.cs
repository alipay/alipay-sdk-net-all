using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotVendingmachineProfileQueryResponse.
    /// </summary>
    public class AlipayCommerceIotVendingmachineProfileQueryResponse : AopResponse
    {
        /// <summary>
        /// 消费者画像列表
        /// </summary>
        [XmlArray("consumer_profile_list")]
        [XmlArrayItem("consumer_profile")]
        public List<ConsumerProfile> ConsumerProfileList { get; set; }

        /// <summary>
        /// 附近人群密度
        /// </summary>
        [XmlArray("nearby_crowd_density_list")]
        [XmlArrayItem("nearby_crowd_density")]
        public List<NearbyCrowdDensity> NearbyCrowdDensityList { get; set; }

        /// <summary>
        /// 推荐商品列表
        /// </summary>
        [XmlArray("recommend_goods_list")]
        [XmlArrayItem("recommend_goods")]
        public List<RecommendGoods> RecommendGoodsList { get; set; }

        /// <summary>
        /// 货柜销售数据统计
        /// </summary>
        [XmlArray("sales_data_list")]
        [XmlArrayItem("sales_data")]
        public List<SalesData> SalesDataList { get; set; }
    }
}
