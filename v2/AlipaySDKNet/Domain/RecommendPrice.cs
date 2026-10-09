using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecommendPrice Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendPrice : AopObject
    {
        /// <summary>
        /// 商品价格在商户中的占比权重，小数表示；如果使用百分比需自行转化
        /// </summary>
        [XmlElement("freq")]
        public string Freq { get; set; }

        /// <summary>
        /// 是否推荐，1推荐，0不推荐
        /// </summary>
        [XmlElement("is_suggest_price")]
        public string IsSuggestPrice { get; set; }

        /// <summary>
        /// 推荐的价格，单位：分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }
    }
}
