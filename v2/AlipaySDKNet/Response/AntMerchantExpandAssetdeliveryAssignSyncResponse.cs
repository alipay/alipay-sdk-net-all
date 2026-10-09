using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryAssignSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetdeliveryAssignSyncResponse : AopResponse
    {
        /// <summary>
        /// 配送指令反馈处理结果.
        /// </summary>
        [XmlArray("delivery_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> DeliveryResults { get; set; }
    }
}
