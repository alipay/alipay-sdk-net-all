using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelInfo : AopObject
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
        /// 资产详情扩展参数
        /// </summary>
        [XmlElement("assets_detail_params")]
        public AssetsDetailParams AssetsDetailParams { get; set; }

        /// <summary>
        /// 渠道可用额度
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 渠道不可用错误码
        /// </summary>
        [XmlElement("close_error_code")]
        public string CloseErrorCode { get; set; }

        /// <summary>
        /// 渠道不可用原因
        /// </summary>
        [XmlElement("close_error_msg")]
        public string CloseErrorMsg { get; set; }

        /// <summary>
        /// 渠道索引
        /// </summary>
        [XmlElement("compatible_channel_index")]
        public string CompatibleChannelIndex { get; set; }

        /// <summary>
        /// 渠道是否可用
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 渠道是否足额
        /// </summary>
        [XmlElement("enough")]
        public bool Enough { get; set; }

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
        /// 资产名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 推荐文案
        /// </summary>
        [XmlElement("recommend_text")]
        public string RecommendText { get; set; }

        /// <summary>
        /// 推荐提示文案
        /// </summary>
        [XmlElement("recommend_tip")]
        public string RecommendTip { get; set; }

        /// <summary>
        /// 渠道是否已签约
        /// </summary>
        [XmlElement("signed")]
        public bool Signed { get; set; }
    }
}
