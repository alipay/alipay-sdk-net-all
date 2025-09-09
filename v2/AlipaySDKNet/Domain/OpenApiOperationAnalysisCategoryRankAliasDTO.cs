using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationAnalysisCategoryRankAliasDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationAnalysisCategoryRankAliasDTO : AopObject
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
        /// 品类ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 品类名称
        /// </summary>
        [XmlElement("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 支付金额，单位：元
        /// </summary>
        [XmlElement("cate_traded_amt")]
        public OperationValueBaseDTO CateTradedAmt { get; set; }

        /// <summary>
        /// 退款金额，单位：元
        /// </summary>
        [XmlElement("cate_traded_refund_amt")]
        public OperationValueBaseDTO CateTradedRefundAmt { get; set; }

        /// <summary>
        /// 商品售量(支付件数)、销量
        /// </summary>
        [XmlElement("cate_traded_sales_cnt")]
        public OperationValueLongDTO CateTradedSalesCnt { get; set; }

        /// <summary>
        /// 访问人数
        /// </summary>
        [XmlElement("cate_uv")]
        public OperationValueLongDTO CateUv { get; set; }

        /// <summary>
        /// 数据平台类型，数据上报的平台类型，枚举值所有情况请查看入参的该字段说明
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 业务的数据日期
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

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
    }
}
