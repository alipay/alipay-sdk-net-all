using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockDeliverydetailFatigueSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockDeliverydetailFatigueSyncModel : AopObject
    {
        /// <summary>
        /// 用户行为
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 签约协议号（uid在某个机构处的唯一标识）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 展位疲劳度
        /// </summary>
        [XmlArray("position_delivery_model")]
        [XmlArrayItem("position_delivery_fatigue_info")]
        public List<PositionDeliveryFatigueInfo> PositionDeliveryModel { get; set; }
    }
}
