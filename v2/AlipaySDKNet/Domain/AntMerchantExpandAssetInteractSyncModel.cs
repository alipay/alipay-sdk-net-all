using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetInteractSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetInteractSyncModel : AopObject
    {
        /// <summary>
        /// 回调使用
        /// </summary>
        [XmlArray("asset_callback_results")]
        [XmlArrayItem("asset_callback_info")]
        public List<AssetCallbackInfo> AssetCallbackResults { get; set; }
    }
}
