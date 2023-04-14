using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointVoucherprodAssetbillQueryResponse.
    /// </summary>
    public class AlipayAssetPointVoucherprodAssetbillQueryResponse : AopResponse
    {
        /// <summary>
        /// 单据流水列表
        /// </summary>
        [XmlArray("asset_bill_info")]
        [XmlArrayItem("asset_bill_info")]
        public List<AssetBillInfo> AssetBillInfo { get; set; }
    }
}
