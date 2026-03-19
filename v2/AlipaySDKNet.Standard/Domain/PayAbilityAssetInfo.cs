using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayAbilityAssetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PayAbilityAssetInfo : AopObject
    {
        /// <summary>
        /// 似同资产
        /// </summary>
        [XmlElement("asset_type_code")]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 渠道编码的展示
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 是否足额参数
        /// </summary>
        [XmlElement("enough")]
        public bool Enough { get; set; }

        /// <summary>
        /// 成功则true
        /// </summary>
        [XmlElement("has_history_pay_success")]
        public bool HasHistoryPaySuccess { get; set; }

        /// <summary>
        /// 代表银行机构，这里表示招商银行
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 标识机构名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }
    }
}
