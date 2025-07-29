using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftCtocAssetQueryResponse.
    /// </summary>
    public class AnttechNftCtocAssetQueryResponse : AopResponse
    {
        /// <summary>
        /// 资产列表
        /// </summary>
        [XmlArray("asset_list")]
        [XmlArrayItem("asset_d_t_o")]
        public List<AssetDTO> AssetList { get; set; }

        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 是否已经实名
        /// </summary>
        [XmlElement("has_real_name")]
        public bool HasRealName { get; set; }

        /// <summary>
        /// 最后的查询游标
        /// </summary>
        [XmlElement("last_index")]
        public long LastIndex { get; set; }
    }
}
