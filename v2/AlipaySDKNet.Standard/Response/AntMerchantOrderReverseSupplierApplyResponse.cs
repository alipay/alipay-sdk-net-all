using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantOrderReverseSupplierApplyResponse.
    /// </summary>
    public class AntMerchantOrderReverseSupplierApplyResponse : AopResponse
    {
        /// <summary>
        /// 未妥投反馈处理结果
        /// </summary>
        [XmlElement("asset_results")]
        public AssetResult AssetResults { get; set; }
    }
}
