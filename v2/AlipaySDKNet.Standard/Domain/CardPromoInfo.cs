using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardPromoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardPromoInfo : AopObject
    {
        /// <summary>
        /// 每期优惠信息
        /// </summary>
        [XmlArray("each_promo_list")]
        [XmlArrayItem("card_each_promo_info")]
        public List<CardEachPromoInfo> EachPromoList { get; set; }

        /// <summary>
        /// 资金模式，预付或先享
        /// </summary>
        [XmlElement("funding_model")]
        public string FundingModel { get; set; }

        /// <summary>
        /// 总优惠价，单位分
        /// </summary>
        [XmlElement("total_promo_price")]
        public long TotalPromoPrice { get; set; }
    }
}
