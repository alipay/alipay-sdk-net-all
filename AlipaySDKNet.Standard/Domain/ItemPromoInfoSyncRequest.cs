using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemPromoInfoSyncRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPromoInfoSyncRequest : AopObject
    {
        /// <summary>
        /// 营销扩展信息
        /// </summary>
        [XmlArray("promo_ext_info")]
        [XmlArrayItem("ext_info_pair")]
        public List<ExtInfoPair> PromoExtInfo { get; set; }

        /// <summary>
        /// 优惠价格
        /// </summary>
        [XmlElement("promo_price")]
        public string PromoPrice { get; set; }

        /// <summary>
        /// 优惠总库存
        /// </summary>
        [XmlElement("promo_stock_total")]
        public long PromoStockTotal { get; set; }

        /// <summary>
        /// 优惠玩法类型
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 优惠失效时间
        /// </summary>
        [XmlElement("valid_time_end")]
        public string ValidTimeEnd { get; set; }

        /// <summary>
        /// 优惠生效时间
        /// </summary>
        [XmlElement("valid_time_start")]
        public string ValidTimeStart { get; set; }
    }
}
