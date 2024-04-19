using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApeRecommendStrategy Data Structure.
    /// </summary>
    [Serializable]
    public class ApeRecommendStrategy : AopObject
    {
        /// <summary>
        /// 点击疲劳的时间间隔，30m表示30分钟，1h表示1小时
        /// </summary>
        [XmlElement("fatigue_click_interval")]
        public string FatigueClickInterval { get; set; }

        /// <summary>
        /// 曝光疲劳的时间间隔，30m表示30分钟，1h表示1小时
        /// </summary>
        [XmlElement("fatigue_expose_interval")]
        public string FatigueExposeInterval { get; set; }

        /// <summary>
        /// 按品牌打散时，不能出现重复的相邻商品个数
        /// </summary>
        [XmlElement("scatter_brand_window_size")]
        public long ScatterBrandWindowSize { get; set; }

        /// <summary>
        /// 商品类目等级，支持1-4级类目
        /// </summary>
        [XmlElement("scatter_cate_level")]
        public long ScatterCateLevel { get; set; }

        /// <summary>
        /// 按类目打散时，不能出现重复的相邻商品个数
        /// </summary>
        [XmlElement("scatter_cate_window_size")]
        public long ScatterCateWindowSize { get; set; }

        /// <summary>
        /// 优先倾向策略的属性，有三个可选值：sales/hot/rating，分别表示高销量、高热度、高评分
        /// </summary>
        [XmlElement("target_tendency_attr")]
        public string TargetTendencyAttr { get; set; }
    }
}
