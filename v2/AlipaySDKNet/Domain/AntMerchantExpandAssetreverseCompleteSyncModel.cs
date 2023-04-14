using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetreverseCompleteSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetreverseCompleteSyncModel : AopObject
    {
        /// <summary>
        /// 取消订单或退货成功入参
        /// </summary>
        [XmlArray("asset_reverse_details")]
        [XmlArrayItem("asset_reverse_detail")]
        public List<AssetReverseDetail> AssetReverseDetails { get; set; }
    }
}
