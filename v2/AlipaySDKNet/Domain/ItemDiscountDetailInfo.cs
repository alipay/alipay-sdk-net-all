using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemDiscountDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDiscountDetailInfo : AopObject
    {
        /// <summary>
        /// 是否可购买
        /// </summary>
        [XmlElement("buy_restrict")]
        public bool BuyRestrict { get; set; }

        /// <summary>
        /// sku列表优惠详情
        /// </summary>
        [XmlArray("consult_detail_info_list")]
        [XmlArrayItem("promo_item_consult_detail_info")]
        public List<PromoItemConsultDetailInfo> ConsultDetailInfoList { get; set; }
    }
}
