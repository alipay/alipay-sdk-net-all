using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAssetinfoCorrectionSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetinfoCorrectionSyncResponse : AopResponse
    {
        /// <summary>
        /// 物料更正请求响应。
        /// </summary>
        [XmlArray("correction_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> CorrectionResults { get; set; }
    }
}
