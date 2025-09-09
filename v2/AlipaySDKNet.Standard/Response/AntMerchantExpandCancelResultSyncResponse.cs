using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandCancelResultSyncResponse.
    /// </summary>
    public class AntMerchantExpandCancelResultSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("asset_result")]
        public AssetResult AssetResult { get; set; }
    }
}
