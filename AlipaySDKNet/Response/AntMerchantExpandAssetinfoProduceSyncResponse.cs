using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAssetinfoProduceSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetinfoProduceSyncResponse : AopResponse
    {
        /// <summary>
        /// 物料信息反馈处理结果
        /// </summary>
        [XmlArray("info_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> InfoResults { get; set; }
    }
}
