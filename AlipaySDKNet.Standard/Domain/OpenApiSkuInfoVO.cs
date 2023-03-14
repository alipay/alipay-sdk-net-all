using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiSkuInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiSkuInfoVO : AopObject
    {
        /// <summary>
        /// 数字类奖项详情
        /// </summary>
        [XmlElement("award_total_info_vo")]
        public OpenApiAwardTotalInfoVO AwardTotalInfoVo { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 最大分享人数
        /// </summary>
        [XmlElement("max_count")]
        public long MaxCount { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        [XmlElement("share_desc")]
        public string ShareDesc { get; set; }

        /// <summary>
        /// 分享头像信息
        /// </summary>
        [XmlArray("share_info")]
        [XmlArrayItem("open_api_user_detail_info")]
        public List<OpenApiUserDetailInfo> ShareInfo { get; set; }

        /// <summary>
        /// 商品已获得后详情跳转链接
        /// </summary>
        [XmlElement("sku_detail_url")]
        public string SkuDetailUrl { get; set; }

        /// <summary>
        /// 商品获得前跳转链接
        /// </summary>
        [XmlElement("sku_get_url")]
        public string SkuGetUrl { get; set; }

        /// <summary>
        /// 单品id
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku图片
        /// </summary>
        [XmlElement("sku_img")]
        public string SkuImg { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("sku_state")]
        public string SkuState { get; set; }

        /// <summary>
        /// sku类型
        /// </summary>
        [XmlElement("sku_type")]
        public string SkuType { get; set; }
    }
}
