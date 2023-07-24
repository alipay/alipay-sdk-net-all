using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoApplyItemInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class PromoApplyItemInfoVO : AopObject
    {
        /// <summary>
        /// 商品平台侧ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品申领明细列表
        /// </summary>
        [XmlArray("promo_apply_item_detail_infos")]
        [XmlArrayItem("promo_apply_item_detail_info_v_o")]
        public List<PromoApplyItemDetailInfoVO> PromoApplyItemDetailInfos { get; set; }

        /// <summary>
        /// 商品skuid
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
