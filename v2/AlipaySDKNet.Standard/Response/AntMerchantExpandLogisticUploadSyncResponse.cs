using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandLogisticUploadSyncResponse.
    /// </summary>
    public class AntMerchantExpandLogisticUploadSyncResponse : AopResponse
    {
        /// <summary>
        /// 上门取件物流信息处理结果
        /// </summary>
        [XmlElement("asset_results")]
        public AssetResult AssetResults { get; set; }
    }
}
