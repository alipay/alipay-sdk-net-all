using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AutohomeDealStatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AutohomeDealStatusModel : AopObject
    {
        /// <summary>
        /// 留资选择品牌
        /// </summary>
        [XmlElement("clue_brand_id")]
        public string ClueBrandId { get; set; }

        /// <summary>
        /// 实际购车品牌
        /// </summary>
        [XmlElement("deal_brand_id")]
        public string DealBrandId { get; set; }

        /// <summary>
        /// 实际购车车系
        /// </summary>
        [XmlElement("deal_series_id")]
        public string DealSeriesId { get; set; }
    }
}
