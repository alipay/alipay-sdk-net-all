using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenMarketingRegionDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenMarketingRegionDTO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("marketing_item_list")]
        [XmlArrayItem("open_marketing_item_d_t_o")]
        public List<OpenMarketingItemDTO> MarketingItemList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("region_action_list")]
        [XmlArrayItem("open_marketing_action_d_t_o")]
        public List<OpenMarketingActionDTO> RegionActionList { get; set; }

        /// <summary>
        /// 展区背景图片
        /// </summary>
        [XmlElement("region_bg_pic")]
        public string RegionBgPic { get; set; }

        /// <summary>
        /// 展区ID
        /// </summary>
        [XmlElement("region_id")]
        public string RegionId { get; set; }

        /// <summary>
        /// 展区名称
        /// </summary>
        [XmlElement("region_name")]
        public string RegionName { get; set; }

        /// <summary>
        /// 展区位置
        /// </summary>
        [XmlElement("region_position")]
        public string RegionPosition { get; set; }
    }
}
