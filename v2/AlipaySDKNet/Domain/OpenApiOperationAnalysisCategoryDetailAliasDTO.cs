using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationAnalysisCategoryDetailAliasDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationAnalysisCategoryDetailAliasDTO : AopObject
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
        /// 加购人数
        /// </summary>
        [XmlElement("cate_add_user_cnt")]
        public OperationValueLongDTO CateAddUserCnt { get; set; }

        /// <summary>
        /// 曝光量
        /// </summary>
        [XmlElement("cate_expo_pv")]
        public OperationValueLongDTO CateExpoPv { get; set; }

        /// <summary>
        /// 品类ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 月复购率
        /// </summary>
        [XmlElement("cate_month_repurchase_rate")]
        public OperationValueBaseDTO CateMonthRepurchaseRate { get; set; }

        /// <summary>
        /// 品类名称
        /// </summary>
        [XmlElement("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 下单支付人数转化率
        /// </summary>
        [XmlElement("cate_order_traded_user_cvr")]
        public OperationValueBaseDTO CateOrderTradedUserCvr { get; set; }

        /// <summary>
        /// 下单人数
        /// </summary>
        [XmlElement("cate_order_user_cnt")]
        public OperationValueLongDTO CateOrderUserCnt { get; set; }

        /// <summary>
        /// 品类访问占比
        /// </summary>
        [XmlElement("cate_pv_share_rate")]
        public OperationValueBaseDTO CatePvShareRate { get; set; }

        /// <summary>
        /// 季度复购率
        /// </summary>
        [XmlElement("cate_season_repurchase_rate")]
        public OperationValueBaseDTO CateSeasonRepurchaseRate { get; set; }

        /// <summary>
        /// 支付金额， 单位：元
        /// </summary>
        [XmlElement("cate_traded_amt")]
        public OperationValueBaseDTO CateTradedAmt { get; set; }

        /// <summary>
        /// 支付件数
        /// </summary>
        [XmlElement("cate_traded_sales_cnt")]
        public OperationValueLongDTO CateTradedSalesCnt { get; set; }

        /// <summary>
        /// 品类支付占比
        /// </summary>
        [XmlElement("cate_traded_share_rate")]
        public OperationValueBaseDTO CateTradedShareRate { get; set; }

        /// <summary>
        /// 支付人数
        /// </summary>
        [XmlElement("cate_traded_user_cnt")]
        public OperationValueLongDTO CateTradedUserCnt { get; set; }

        /// <summary>
        /// 访问人数
        /// </summary>
        [XmlElement("cate_uv")]
        public OperationValueLongDTO CateUv { get; set; }

        /// <summary>
        /// 访问后下单人数转化率
        /// </summary>
        [XmlElement("cate_visit_order_user_cvr")]
        public OperationValueBaseDTO CateVisitOrderUserCvr { get; set; }

        /// <summary>
        /// 访问后支付人数转化率
        /// </summary>
        [XmlElement("cate_visit_traded_user_cvr")]
        public OperationValueBaseDTO CateVisitTradedUserCvr { get; set; }

        /// <summary>
        /// 数据平台类型，数据上报的平台类型枚举,所有枚举值情况请查看入参字段的描述
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
