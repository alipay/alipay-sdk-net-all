using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecommendCard Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendCard : AopObject
    {
        /// <summary>
        /// 卡名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 卡的推荐理由，非必须项
        /// </summary>
        [XmlElement("card_recommend_reason")]
        public string CardRecommendReason { get; set; }

        /// <summary>
        /// 卡类型，非必须项
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 卡类目1，非必须项
        /// </summary>
        [XmlElement("cate_1")]
        public string Cate1 { get; set; }

        /// <summary>
        /// 卡类目2，非必须项
        /// </summary>
        [XmlElement("cate_2")]
        public string Cate2 { get; set; }

        /// <summary>
        /// 卡类目3，非必须项
        /// </summary>
        [XmlElement("cate_3")]
        public string Cate3 { get; set; }
    }
}
