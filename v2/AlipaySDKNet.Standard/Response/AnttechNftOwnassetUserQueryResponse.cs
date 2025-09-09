using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftOwnassetUserQueryResponse.
    /// </summary>
    public class AnttechNftOwnassetUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 资产列表
        /// </summary>
        [XmlArray("asset_list")]
        [XmlArrayItem("page_asset_d_t_o")]
        public List<PageAssetDTO> AssetList { get; set; }

        /// <summary>
        /// 分页编号
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总资产数量,个数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
