using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringKmsBakingSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringKmsBakingSyncModel : AopObject
    {
        /// <summary>
        /// 同步:sync; 核对:check;
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 核对数据，如果action=check则必填
        /// </summary>
        [XmlElement("check_data")]
        public KmsBakingCheckDTO CheckData { get; set; }

        /// <summary>
        /// 烘焙库存数据，根据type选填，一次最多批量同步100条数据。
        /// </summary>
        [XmlArray("inventory_data")]
        [XmlArrayItem("kms_baking_inventory_d_t_o")]
        public List<KmsBakingInventoryDTO> InventoryData { get; set; }

        /// <summary>
        /// 烘焙营销数据，根据type选填，一次最多批量同步100条数据。
        /// </summary>
        [XmlArray("promotion_data")]
        [XmlArrayItem("kms_baking_promotion_d_t_o")]
        public List<KmsBakingPromotionDTO> PromotionData { get; set; }

        /// <summary>
        /// 口碑门店Id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 库存：inventory 营销：promotion
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
