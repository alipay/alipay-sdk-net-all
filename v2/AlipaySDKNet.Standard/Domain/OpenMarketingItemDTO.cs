using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenMarketingItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenMarketingItemDTO : AopObject
    {
        /// <summary>
        /// 展品权益概要
        /// </summary>
        [XmlElement("benefit_summary")]
        public string BenefitSummary { get; set; }

        /// <summary>
        /// 核心卖点描述
        /// </summary>
        [XmlElement("core_selling_point_desc")]
        public string CoreSellingPointDesc { get; set; }

        /// <summary>
        /// 权益概要高亮文案
        /// </summary>
        [XmlElement("highlight_text_of_benefit_summary")]
        public string HighlightTextOfBenefitSummary { get; set; }

        /// <summary>
        /// 展品行动点列表
        /// </summary>
        [XmlArray("item_action_list")]
        [XmlArrayItem("open_marketing_action_d_t_o")]
        public List<OpenMarketingActionDTO> ItemActionList { get; set; }

        /// <summary>
        /// 展品背景图
        /// </summary>
        [XmlElement("item_bg_pic")]
        public string ItemBgPic { get; set; }

        /// <summary>
        /// 展品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 展品logo
        /// </summary>
        [XmlElement("item_logo")]
        public string ItemLogo { get; set; }

        /// <summary>
        /// 展品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 展品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 品牌信息(当展品类型是品牌时不为空)
        /// </summary>
        [XmlElement("marketing_brand")]
        public OpenMarketingBrandDTO MarketingBrand { get; set; }
    }
}
