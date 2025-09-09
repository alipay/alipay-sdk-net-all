using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationAnalysisCustomerAliasDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationAnalysisCustomerAliasDTO : AopObject
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
        /// 数据平台端类型，数据上报的平台类型枚举，所有枚举情况请查看入参的该字段。
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
        /// 支付转化率
        /// </summary>
        [XmlElement("order_traded_user_cvr")]
        public OperationValueBaseDTO OrderTradedUserCvr { get; set; }

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
        /// 交易整体转化率
        /// </summary>
        [XmlElement("traded_user_cvr")]
        public OperationValueBaseDTO TradedUserCvr { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }

        /// <summary>
        /// 访问人数
        /// </summary>
        [XmlElement("uv")]
        public OperationValueLongDTO Uv { get; set; }

        /// <summary>
        /// 下单转化率
        /// </summary>
        [XmlElement("visit_order_user_cvr")]
        public OperationValueBaseDTO VisitOrderUserCvr { get; set; }
    }
}
