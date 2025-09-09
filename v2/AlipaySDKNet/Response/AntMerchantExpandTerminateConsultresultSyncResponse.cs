using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandTerminateConsultresultSyncResponse.
    /// </summary>
    public class AntMerchantExpandTerminateConsultresultSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("info_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> InfoResults { get; set; }
    }
}
