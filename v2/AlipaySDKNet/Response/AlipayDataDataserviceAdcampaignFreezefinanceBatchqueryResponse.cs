using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignFreezefinanceBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignFreezefinanceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 冻结单信息
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("ad_special_asset_list_res")]
        public List<AdSpecialAssetListRes> Data { get; set; }
    }
}
