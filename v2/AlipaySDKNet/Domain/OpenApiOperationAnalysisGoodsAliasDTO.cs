using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationAnalysisGoodsAliasDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationAnalysisGoodsAliasDTO : AopObject
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
        /// 数据平台类型，数据上报的平台类型枚举，枚举值列表请见入参的channel_type得描述
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

        /// <summary>
        /// 客单价，单位：元
        /// </summary>
        [XmlElement("per_customer_price")]
        public OperationValueBaseDTO PerCustomerPrice { get; set; }

        /// <summary>
        /// 笔单价，单位：元
        /// </summary>
        [XmlElement("per_unit_price")]
        public OperationValueBaseDTO PerUnitPrice { get; set; }

        /// <summary>
        /// 加购笔数
        /// </summary>
        [XmlElement("spu_add_order_cnt")]
        public OperationValueLongDTO SpuAddOrderCnt { get; set; }

        /// <summary>
        /// 加购件数
        /// </summary>
        [XmlElement("spu_add_sku_cnt")]
        public OperationValueLongDTO SpuAddSkuCnt { get; set; }

        /// <summary>
        /// 加购人数
        /// </summary>
        [XmlElement("spu_add_user_cnt")]
        public OperationValueLongDTO SpuAddUserCnt { get; set; }

        /// <summary>
        /// 商品曝光量
        /// </summary>
        [XmlElement("spu_expo_pv")]
        public OperationValueLongDTO SpuExpoPv { get; set; }

        /// <summary>
        /// 月复购率
        /// </summary>
        [XmlElement("spu_month_repurchase_rate")]
        public OperationValueBaseDTO SpuMonthRepurchaseRate { get; set; }

        /// <summary>
        /// 下单金额，单位：元
        /// </summary>
        [XmlElement("spu_order_amt")]
        public OperationValueBaseDTO SpuOrderAmt { get; set; }

        /// <summary>
        /// 下单笔数
        /// </summary>
        [XmlElement("spu_order_cnt")]
        public OperationValueLongDTO SpuOrderCnt { get; set; }

        /// <summary>
        /// 下单人数
        /// </summary>
        [XmlElement("spu_order_user_cnt")]
        public OperationValueLongDTO SpuOrderUserCnt { get; set; }

        /// <summary>
        /// 退款金额，单位：元
        /// </summary>
        [XmlElement("spu_refund_amt")]
        public OperationValueBaseDTO SpuRefundAmt { get; set; }

        /// <summary>
        /// 退款笔数
        /// </summary>
        [XmlElement("spu_refund_cnt")]
        public OperationValueLongDTO SpuRefundCnt { get; set; }

        /// <summary>
        /// 退款人数
        /// </summary>
        [XmlElement("spu_refund_user_cnt")]
        public OperationValueLongDTO SpuRefundUserCnt { get; set; }

        /// <summary>
        /// 季度复购率
        /// </summary>
        [XmlElement("spu_season_repurchase_rate")]
        public OperationValueBaseDTO SpuSeasonRepurchaseRate { get; set; }

        /// <summary>
        /// 支付金额，单位：元
        /// </summary>
        [XmlElement("spu_traded_amt")]
        public OperationValueBaseDTO SpuTradedAmt { get; set; }

        /// <summary>
        /// 支付笔数
        /// </summary>
        [XmlElement("spu_traded_cnt")]
        public OperationValueLongDTO SpuTradedCnt { get; set; }

        /// <summary>
        /// 退款人数转化率
        /// </summary>
        [XmlElement("spu_traded_refund_user_cvr")]
        public OperationValueBaseDTO SpuTradedRefundUserCvr { get; set; }

        /// <summary>
        /// 支付人数
        /// </summary>
        [XmlElement("spu_traded_user_cnt")]
        public OperationValueLongDTO SpuTradedUserCnt { get; set; }

        /// <summary>
        /// 未支付金额，单位：元
        /// </summary>
        [XmlElement("spu_untraded_amt")]
        public OperationValueBaseDTO SpuUntradedAmt { get; set; }

        /// <summary>
        /// 未支付笔数
        /// </summary>
        [XmlElement("spu_untraded_cnt")]
        public OperationValueLongDTO SpuUntradedCnt { get; set; }

        /// <summary>
        /// 未支付人数
        /// </summary>
        [XmlElement("spu_untraded_user_cnt")]
        public OperationValueLongDTO SpuUntradedUserCnt { get; set; }

        /// <summary>
        /// 商品访问人数
        /// </summary>
        [XmlElement("spu_uv")]
        public OperationValueLongDTO SpuUv { get; set; }

        /// <summary>
        /// 访问商品后加购人数转化率
        /// </summary>
        [XmlElement("spu_visit_add_user_cvr")]
        public OperationValueBaseDTO SpuVisitAddUserCvr { get; set; }

        /// <summary>
        /// 被访问商品数
        /// </summary>
        [XmlElement("spu_visit_cnt")]
        public OperationValueLongDTO SpuVisitCnt { get; set; }

        /// <summary>
        /// 访问商品后下单人数转化率
        /// </summary>
        [XmlElement("spu_visit_order_user_cvr")]
        public OperationValueBaseDTO SpuVisitOrderUserCvr { get; set; }

        /// <summary>
        /// 访问商品后支付人数转化率
        /// </summary>
        [XmlElement("spu_visit_traded_user_cvr")]
        public OperationValueBaseDTO SpuVisitTradedUserCvr { get; set; }

        /// <summary>
        /// 未支付人数转化率
        /// </summary>
        [XmlElement("spu_visit_untrade_user_cvr")]
        public OperationValueBaseDTO SpuVisitUntradeUserCvr { get; set; }
    }
}
