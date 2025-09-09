using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallItemSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallItemSyncModel : AopObject
    {
        /// <summary>
        /// 分销店铺id
        /// </summary>
        [XmlElement("purchaser_id")]
        public string PurchaserId { get; set; }
    }
}
