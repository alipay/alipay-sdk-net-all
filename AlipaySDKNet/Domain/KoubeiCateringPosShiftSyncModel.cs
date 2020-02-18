using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringPosShiftSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosShiftSyncModel : AopObject
    {
        /// <summary>
        /// 班次信息
        /// </summary>
        [XmlArray("schedules")]
        [XmlArrayItem("shop_pos_schedule")]
        public List<ShopPosSchedule> Schedules { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
