using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTourAssetDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTourAssetDeleteModel : AopObject
    {
        /// <summary>
        /// 用户资产出库实体类集合
        /// </summary>
        [XmlArray("asset_out_put_list")]
        [XmlArrayItem("asset_out_put_request")]
        public List<AssetOutPutRequest> AssetOutPutList { get; set; }
    }
}
