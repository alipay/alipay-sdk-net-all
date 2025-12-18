using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftCtocAssetcountQueryResponse.
    /// </summary>
    public class AnttechNftCtocAssetcountQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询分区
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// 持有资产总数
        /// </summary>
        [XmlElement("total_owned_asset_num")]
        public long TotalOwnedAssetNum { get; set; }
    }
}
