using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationAnalysisCustomerTrdLvlAliasDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationAnalysisCustomerTrdLvlAliasDTO : AopObject
    {
        /// <summary>
        /// 小程序应用ID，分配给开发者的应用ID
        /// </summary>
        [XmlElement("alipay_app_id")]
        public string AlipayAppId { get; set; }

        /// <summary>
        /// 小程序应用名称，开发者的应用设置的小程序应用名称
        /// </summary>
        [XmlElement("alipay_app_name")]
        public string AlipayAppName { get; set; }

        /// <summary>
        /// 数据平台类型，数据上报的平台类型枚举.所有枚举情况可以查看入参的该字段的描述
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 业务的数据日期
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// 消费层级总人数
        /// </summary>
        [XmlElement("level_all_uv")]
        public OperationValueLongDTO LevelAllUv { get; set; }

        /// <summary>
        /// 层级访问人数
        /// </summary>
        [XmlElement("level_uv")]
        public OperationValueLongDTO LevelUv { get; set; }

        /// <summary>
        /// 层级访问人数占比
        /// </summary>
        [XmlElement("level_uv_percent")]
        public OperationValueBaseDTO LevelUvPercent { get; set; }

        /// <summary>
        /// 多端小程序应用ID，非支付宝平台的其他平台的小程序应用ID
        /// </summary>
        [XmlElement("multi_app_id")]
        public string MultiAppId { get; set; }

        /// <summary>
        /// 多端小程序应用名称，非支付宝平台的小程序应用名称
        /// </summary>
        [XmlElement("multi_app_name")]
        public string MultiAppName { get; set; }

        /// <summary>
        /// 消费层级粒度
        /// </summary>
        [XmlElement("trade_level_granularity")]
        public OperationValueLongDTO TradeLevelGranularity { get; set; }

        /// <summary>
        /// 消费层级
        /// </summary>
        [XmlElement("traded_level")]
        public string TradedLevel { get; set; }
    }
}
