using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandRankDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BrandRankDTO : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 品牌排行
        /// </summary>
        [XmlElement("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// 交易金额指数，在所选周期内（如某个自然周、自然月），按交易金额的多少换算成的指数指标。交易金额指数越高，代表交易金额越多，单位元
        /// </summary>
        [XmlElement("trd_amt_index")]
        public long TrdAmtIndex { get; set; }
    }
}
