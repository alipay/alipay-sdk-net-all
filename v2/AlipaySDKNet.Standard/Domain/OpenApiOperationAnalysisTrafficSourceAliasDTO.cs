using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationAnalysisTrafficSourceAliasDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationAnalysisTrafficSourceAliasDTO : AopObject
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
        /// 数据平台类型，数据上报的平台类型
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 业务的数据日期
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// 一级来源渠道
        /// </summary>
        [XmlElement("first_source_type")]
        public string FirstSourceType { get; set; }

        /// <summary>
        /// 多端小程序应用ID，非支付宝平台的其他平台的小程序应用ID
        /// </summary>
        [XmlElement("multi_app_id")]
        public string MultiAppId { get; set; }

        /// <summary>
        /// 多端小程序应用ID，非支付宝平台的其他平台的小程序应用ID
        /// </summary>
        [XmlElement("multi_app_name")]
        public string MultiAppName { get; set; }

        /// <summary>
        /// 二级来源渠道
        /// </summary>
        [XmlElement("second_source_type")]
        public string SecondSourceType { get; set; }

        /// <summary>
        /// 加购人数
        /// </summary>
        [XmlElement("tapp_add_user_cnt")]
        public OperationValueLongDTO TappAddUserCnt { get; set; }

        /// <summary>
        /// 下单支付人数转化率
        /// </summary>
        [XmlElement("tapp_order_traded_user_cvr")]
        public OperationValueBaseDTO TappOrderTradedUserCvr { get; set; }

        /// <summary>
        /// 下单人数
        /// </summary>
        [XmlElement("tapp_order_user_cnt")]
        public OperationValueLongDTO TappOrderUserCnt { get; set; }

        /// <summary>
        /// 支付人数
        /// </summary>
        [XmlElement("tapp_traded_user_cnt")]
        public OperationValueLongDTO TappTradedUserCnt { get; set; }

        /// <summary>
        /// 场景访问人数
        /// </summary>
        [XmlElement("tapp_uv")]
        public OperationValueLongDTO TappUv { get; set; }

        /// <summary>
        /// 场景访问人数占比
        /// </summary>
        [XmlElement("tapp_uv_rate")]
        public OperationValueBaseDTO TappUvRate { get; set; }

        /// <summary>
        /// 访问下单人数转化率
        /// </summary>
        [XmlElement("tapp_visit_order_user_cvr")]
        public OperationValueBaseDTO TappVisitOrderUserCvr { get; set; }

        /// <summary>
        /// 访问支付人数转化率
        /// </summary>
        [XmlElement("tapp_visit_traded_user_cvr")]
        public OperationValueBaseDTO TappVisitTradedUserCvr { get; set; }
    }
}
