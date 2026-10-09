using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAssetInteractSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetInteractSyncResponse : AopResponse
    {
        /// <summary>
        /// 回调结果
        /// </summary>
        [XmlArray("asset_callback_results")]
        [XmlArrayItem("asset_callback_info")]
        public List<AssetCallbackInfo> AssetCallbackResults { get; set; }
    }
}
