using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationOverviewAliasDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationOverviewAliasDTO : AopObject
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
        /// 数据平台类型，数据上报的平台类型枚举,非必传，如不传则默认为ALIPAY
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
        /// 客单价, 单位: 元
        /// </summary>
        [XmlElement("per_customer_price")]
        public OperationValueBaseDTO PerCustomerPrice { get; set; }

        /// <summary>
        /// 笔单价, 单位: 元
        /// </summary>
        [XmlElement("per_unit_price")]
        public OperationValueBaseDTO PerUnitPrice { get; set; }

        /// <summary>
        /// 商家账户ID，经营概况模块由于是默认支持商户粒度的数据分析，故会返回pid商户信息
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 商家账户名称，经营概况模块由于是默认支持商户粒度的数据分析，故会返回pid商户信息
        /// </summary>
        [XmlElement("pid_name")]
        public string PidName { get; set; }

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
        /// 季度复购率
        /// </summary>
        [XmlElement("spu_season_repurchase_rate")]
        public OperationValueBaseDTO SpuSeasonRepurchaseRate { get; set; }

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
        /// 加购笔数
        /// </summary>
        [XmlElement("tapp_add_order_cnt")]
        public OperationValueLongDTO TappAddOrderCnt { get; set; }

        /// <summary>
        /// 加购件数
        /// </summary>
        [XmlElement("tapp_add_sku_cnt")]
        public OperationValueLongDTO TappAddSkuCnt { get; set; }

        /// <summary>
        /// 加购人数
        /// </summary>
        [XmlElement("tapp_add_user_cnt")]
        public OperationValueLongDTO TappAddUserCnt { get; set; }

        /// <summary>
        /// 新增小程序访客数
        /// </summary>
        [XmlElement("tapp_new_uv")]
        public OperationValueLongDTO TappNewUv { get; set; }

        /// <summary>
        /// 小程序老访客数
        /// </summary>
        [XmlElement("tapp_old_uv")]
        public OperationValueLongDTO TappOldUv { get; set; }

        /// <summary>
        /// 下单金额, 单位: 元
        /// </summary>
        [XmlElement("tapp_order_amt")]
        public OperationValueBaseDTO TappOrderAmt { get; set; }

        /// <summary>
        /// 下单笔数
        /// </summary>
        [XmlElement("tapp_order_cnt")]
        public OperationValueLongDTO TappOrderCnt { get; set; }

        /// <summary>
        /// 下单人数
        /// </summary>
        [XmlElement("tapp_order_user_cnt")]
        public OperationValueLongDTO TappOrderUserCnt { get; set; }

        /// <summary>
        /// 小程序打开次数
        /// </summary>
        [XmlElement("tapp_pv")]
        public OperationValueLongDTO TappPv { get; set; }

        /// <summary>
        /// 退款金额, 单位: 元
        /// </summary>
        [XmlElement("tapp_refund_amt")]
        public OperationValueBaseDTO TappRefundAmt { get; set; }

        /// <summary>
        /// 退款笔数
        /// </summary>
        [XmlElement("tapp_refund_cnt")]
        public OperationValueLongDTO TappRefundCnt { get; set; }

        /// <summary>
        /// 退款人数
        /// </summary>
        [XmlElement("tapp_refund_user_cnt")]
        public OperationValueLongDTO TappRefundUserCnt { get; set; }

        /// <summary>
        /// 支付金额, 单位: 元
        /// </summary>
        [XmlElement("tapp_traded_amt")]
        public OperationValueBaseDTO TappTradedAmt { get; set; }

        /// <summary>
        /// 支付笔数
        /// </summary>
        [XmlElement("tapp_traded_cnt")]
        public OperationValueLongDTO TappTradedCnt { get; set; }

        /// <summary>
        /// 退款人数转化率
        /// </summary>
        [XmlElement("tapp_traded_refund_user_cvr")]
        public OperationValueBaseDTO TappTradedRefundUserCvr { get; set; }

        /// <summary>
        /// 支付人数
        /// </summary>
        [XmlElement("tapp_traded_user_cnt")]
        public OperationValueLongDTO TappTradedUserCnt { get; set; }

        /// <summary>
        /// 未支付金额, 单位: 元
        /// </summary>
        [XmlElement("tapp_untraded_amt")]
        public OperationValueBaseDTO TappUntradedAmt { get; set; }

        /// <summary>
        /// 未支付笔数
        /// </summary>
        [XmlElement("tapp_untraded_cnt")]
        public OperationValueLongDTO TappUntradedCnt { get; set; }

        /// <summary>
        /// 未支付人数
        /// </summary>
        [XmlElement("tapp_untraded_user_cnt")]
        public OperationValueLongDTO TappUntradedUserCnt { get; set; }

        /// <summary>
        /// 小程序访问人数
        /// </summary>
        [XmlElement("tapp_uv")]
        public OperationValueLongDTO TappUv { get; set; }

        /// <summary>
        /// 访问小程序后加购人数转化率
        /// </summary>
        [XmlElement("tapp_visit_add_user_cvr")]
        public OperationValueBaseDTO TappVisitAddUserCvr { get; set; }

        /// <summary>
        /// 访问小程序后下单人数转化率
        /// </summary>
        [XmlElement("tapp_visit_order_user_cvr")]
        public OperationValueBaseDTO TappVisitOrderUserCvr { get; set; }

        /// <summary>
        /// 访问小程序后支付人数转化率
        /// </summary>
        [XmlElement("tapp_visit_traded_user_cvr")]
        public OperationValueBaseDTO TappVisitTradedUserCvr { get; set; }

        /// <summary>
        /// 未支付人数转化率
        /// </summary>
        [XmlElement("tapp_visit_untraded_user_cvr")]
        public OperationValueBaseDTO TappVisitUntradedUserCvr { get; set; }

        /// <summary>
        /// 小程序云数据模板，用于对分析数据的过滤筛选的条件参数，不传时代表不参与数据模板条件过滤
        /// </summary>
        [XmlElement("template")]
        public string Template { get; set; }
    }
}
