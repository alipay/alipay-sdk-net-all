using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftCtocAssetascQueryResponse.
    /// </summary>
    public class AnttechNftCtocAssetascQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("asset_list")]
        [XmlArrayItem("asset_d_t_o")]
        public List<AssetDTO> AssetList { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 是否实名
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
