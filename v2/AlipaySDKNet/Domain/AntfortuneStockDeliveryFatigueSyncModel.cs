using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockDeliveryFatigueSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockDeliveryFatigueSyncModel : AopObject
    {
        /// <summary>
        /// 签约协议号（uid在某个机构处的唯一标识）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 投放疲劳度内容，包含展位码、行为以及疲劳度配置信息
        /// </summary>
        [XmlArray("delivery_fatigue")]
        [XmlArrayItem("delivery_fatigue")]
        public List<DeliveryFatigue> DeliveryFatigue { get; set; }
    }
}
