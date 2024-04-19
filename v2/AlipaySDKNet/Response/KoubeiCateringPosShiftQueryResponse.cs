using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosShiftQueryResponse.
    /// </summary>
    public class KoubeiCateringPosShiftQueryResponse : AopResponse
    {
        /// <summary>
        /// 班次信息列表
        /// </summary>
        [XmlArray("shop_pos_schedules")]
        [XmlArrayItem("shop_pos_schedule")]
        public List<ShopPosSchedule> ShopPosSchedules { get; set; }
    }
}
