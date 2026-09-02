using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecifiedSortChannelParam Data Structure.
    /// </summary>
    [Serializable]
    public class SpecifiedSortChannelParam : AopObject
    {
        /// <summary>
        /// 资产编码
        /// </summary>
        [XmlElement("asset_type_code")]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 指定支付渠道标识
        /// </summary>
        [XmlElement("assigned_channel")]
        public string AssignedChannel { get; set; }

        /// <summary>
        /// 支付渠道名称
        /// </summary>
        [XmlElement("channel_full_name")]
        public string ChannelFullName { get; set; }

        /// <summary>
        /// 支付渠道索引
        /// </summary>
        [XmlElement("channel_index")]
        public string ChannelIndex { get; set; }
    }
}
