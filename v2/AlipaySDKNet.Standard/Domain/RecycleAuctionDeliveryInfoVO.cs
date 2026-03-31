using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleAuctionDeliveryInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleAuctionDeliveryInfoVO : AopObject
    {
        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("logistics_bill_no")]
        public string LogisticsBillNo { get; set; }

        /// <summary>
        /// 物流平台
        /// </summary>
        [XmlElement("logistics_platform")]
        public string LogisticsPlatform { get; set; }

        /// <summary>
        /// 物流状态
        /// </summary>
        [XmlElement("logistics_status")]
        public string LogisticsStatus { get; set; }
    }
}
