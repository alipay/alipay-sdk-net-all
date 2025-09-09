using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationAnalysisTrafficPageAliasDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationAnalysisTrafficPageAliasDTO : AopObject
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
        /// 数据平台类型，数据上报的平台类型枚举
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 业务的数据日期
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// 页面跳失人数
        /// </summary>
        [XmlElement("end_page_user_cnt")]
        public OperationValueLongDTO EndPageUserCnt { get; set; }

        /// <summary>
        /// 页面跳失率
        /// </summary>
        [XmlElement("end_page_user_cnt_rate")]
        public OperationValueBaseDTO EndPageUserCntRate { get; set; }

        /// <summary>
        /// 页面引导加购下单转化率
        /// </summary>
        [XmlElement("guid_add_order_user_cvr")]
        public OperationValueBaseDTO GuidAddOrderUserCvr { get; set; }

        /// <summary>
        /// 页面引导加购人数
        /// </summary>
        [XmlElement("guid_add_user_cnt")]
        public OperationValueLongDTO GuidAddUserCnt { get; set; }

        /// <summary>
        /// 页面引导下单人数
        /// </summary>
        [XmlElement("guid_order_user_cnt")]
        public OperationValueLongDTO GuidOrderUserCnt { get; set; }

        /// <summary>
        /// 页面分享次数
        /// </summary>
        [XmlElement("guid_share_cnt")]
        public OperationValueLongDTO GuidShareCnt { get; set; }

        /// <summary>
        /// 页面分享人数
        /// </summary>
        [XmlElement("guid_share_user_cnt")]
        public OperationValueLongDTO GuidShareUserCnt { get; set; }

        /// <summary>
        /// 页面引导访问-加购转化率
        /// </summary>
        [XmlElement("guid_visit_add_user_cvr")]
        public OperationValueBaseDTO GuidVisitAddUserCvr { get; set; }

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
        /// 页面名称
        /// </summary>
        [XmlElement("page_name")]
        public string PageName { get; set; }

        /// <summary>
        /// 页面URL，页面名称的子集
        /// </summary>
        [XmlElement("page_url")]
        public string PageUrl { get; set; }

        /// <summary>
        /// 页面浏览量
        /// </summary>
        [XmlElement("pv")]
        public OperationValueLongDTO Pv { get; set; }

        /// <summary>
        /// 页面平均停留时长，单位：秒
        /// </summary>
        [XmlElement("stay_second_avg")]
        public OperationValueLongDTO StaySecondAvg { get; set; }

        /// <summary>
        /// 页面访问人数
        /// </summary>
        [XmlElement("uv")]
        public OperationValueLongDTO Uv { get; set; }
    }
}
