using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiAnalysisCommonRequest Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiAnalysisCommonRequest : AopObject
    {
        /// <summary>
        /// 可选，端类型，数据上报的端平台枚举，如不传则默认为ALIPAY
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 数据对比类型，可选择对比同期或不对比。不传则默认为NO_COMPARE不对比。
        /// </summary>
        [XmlElement("compare_type")]
        public string CompareType { get; set; }

        /// <summary>
        /// 查询统计的结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 可选，多端小程序appId，若端类型包含非支付宝端（即channel_type不等于ALIPAY）时，需要传入的其他端小程序ID
        /// </summary>
        [XmlElement("multi_app_id")]
        public string MultiAppId { get; set; }

        /// <summary>
        /// 可选，统计的开始时间，若选自定义时间粒度.开始日期必传。格式：YYYYMMDD
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 必填，时间粒度，单位 ：天 (day)
        /// </summary>
        [XmlElement("time_granularity")]
        public string TimeGranularity { get; set; }
    }
}
