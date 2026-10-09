using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandLogisticUploadSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandLogisticUploadSyncModel : AopObject
    {
        /// <summary>
        /// 回收场景上门取件后回传上门取件状态以及上门取件物流信息
        /// </summary>
        [XmlElement("asset_pickup_logistic_detail")]
        public AssetPickupLogisticsDetail AssetPickupLogisticDetail { get; set; }
    }
}
