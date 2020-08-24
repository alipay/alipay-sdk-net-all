using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityDataAmlassetBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityDataAmlassetBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 风险资产记录结果列表
        /// </summary>
        [XmlArray("asset_records")]
        [XmlArrayItem("aml_asset_record")]
        public List<AmlAssetRecord> AssetRecords { get; set; }
    }
}
