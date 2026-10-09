using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitRecordQueryContent Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitRecordQueryContent : AopObject
    {
        /// <summary>
        /// 权益订单信息
        /// </summary>
        [XmlArray("play_luck_draw_order_infos")]
        [XmlArrayItem("benefit_order_info")]
        public List<BenefitOrderInfo> PlayLuckDrawOrderInfos { get; set; }
    }
}
