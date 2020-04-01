using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecommendServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendServiceInfo : AopObject
    {
        /// <summary>
        /// 一级类目
        /// </summary>
        [XmlElement("cate_1")]
        public string Cate1 { get; set; }

        /// <summary>
        /// 二级类目
        /// </summary>
        [XmlElement("cate_2")]
        public string Cate2 { get; set; }

        /// <summary>
        /// 三级类目
        /// </summary>
        [XmlElement("cate_3")]
        public string Cate3 { get; set; }

        /// <summary>
        /// 是否是首选项
        /// </summary>
        [XmlElement("first_choose")]
        public bool FirstChoose { get; set; }

        /// <summary>
        /// 套餐最高价
        /// </summary>
        [XmlElement("max_price")]
        public long MaxPrice { get; set; }

        /// <summary>
        /// 套餐最低价
        /// </summary>
        [XmlElement("min_price")]
        public string MinPrice { get; set; }

        /// <summary>
        /// 服务推荐原因
        /// </summary>
        [XmlElement("recommend_reason")]
        public string RecommendReason { get; set; }

        /// <summary>
        /// 店铺星级
        /// </summary>
        [XmlElement("star")]
        public long Star { get; set; }
    }
}
