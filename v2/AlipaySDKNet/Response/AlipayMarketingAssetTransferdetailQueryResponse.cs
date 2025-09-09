using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingAssetTransferdetailQueryResponse.
    /// </summary>
    public class AlipayMarketingAssetTransferdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// [{}]
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("asset_transfer_detail_d_t_o")]
        public List<AssetTransferDetailDTO> Details { get; set; }
    }
}
