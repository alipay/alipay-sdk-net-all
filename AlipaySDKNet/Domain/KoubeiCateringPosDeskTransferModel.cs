using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDeskTransferModel : AopObject
    {
        /// <summary>
        /// 餐区信息
        /// </summary>
        [XmlArray("sort_area")]
        [XmlArrayItem("desk_area_entity")]
        public List<DeskAreaEntity> SortArea { get; set; }

        /// <summary>
        /// 桌位排序list
        /// </summary>
        [XmlArray("sort_desk")]
        [XmlArrayItem("sort_desk_param")]
        public List<SortDeskParam> SortDesk { get; set; }
    }
}
