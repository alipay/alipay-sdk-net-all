using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelItem Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelItem : AopObject
    {
        /// <summary>
        /// 资产ID
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 资产编码
        /// </summary>
        [XmlElement("asset_type_code")]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 渠道索引
        /// </summary>
        [XmlElement("channel_index")]
        public string ChannelIndex { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 渠道logo图片的url地址
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 渠道运营文案
        /// </summary>
        [XmlElement("recommend_tip")]
        public string RecommendTip { get; set; }
    }
}
