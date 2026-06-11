using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherDetailModel : AopObject
    {
        /// <summary>
        /// 可用渠道信息，可用于指定渠道优先展示
        /// </summary>
        [XmlArray("can_use_asset_channel_infos")]
        [XmlArrayItem("asset_channel_info")]
        public List<AssetChannelInfo> CanUseAssetChannelInfos { get; set; }
    }
}
