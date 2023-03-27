using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopRecommendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopRecommendInfo : AopObject
    {
        /// <summary>
        /// 门店修改建议
        /// </summary>
        [XmlElement("recommend")]
        public string Recommend { get; set; }

        /// <summary>
        /// 推荐详细地址
        /// </summary>
        [XmlElement("recommend_address")]
        public string RecommendAddress { get; set; }

        /// <summary>
        /// 推荐纬度
        /// </summary>
        [XmlElement("recommend_latitude")]
        public string RecommendLatitude { get; set; }

        /// <summary>
        /// 推荐经度
        /// </summary>
        [XmlElement("recommend_longtitude")]
        public string RecommendLongtitude { get; set; }

        /// <summary>
        /// 推荐门店名称
        /// </summary>
        [XmlElement("recommend_name")]
        public string RecommendName { get; set; }

        /// <summary>
        /// 门店不置信原因
        /// </summary>
        [XmlElement("unconfidence_reason")]
        public string UnconfidenceReason { get; set; }
    }
}
