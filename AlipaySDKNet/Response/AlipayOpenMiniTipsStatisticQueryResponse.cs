using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniTipsStatisticQueryResponse.
    /// </summary>
    public class AlipayOpenMiniTipsStatisticQueryResponse : AopResponse
    {
        /// <summary>
        /// 昨日小程序收藏人数
        /// </summary>
        [XmlElement("app_collect_cnt")]
        public long AppCollectCnt { get; set; }

        /// <summary>
        /// 昨日小程序访问人数
        /// </summary>
        [XmlElement("app_uv")]
        public long AppUv { get; set; }

        /// <summary>
        /// 收藏文案内容（仅以app维度查询时为空）
        /// </summary>
        [XmlElement("delivery_content")]
        public string DeliveryContent { get; set; }

        /// <summary>
        /// 收藏引导投放活动ID（仅以app维度查询时为空）
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 昨日收藏引导文案收藏转化率，数据为小数字符串类型，取小数点后两位，单位为百分比。
        /// </summary>
        [XmlElement("tips_collect_rate")]
        public string TipsCollectRate { get; set; }

        /// <summary>
        /// 昨日收藏引导文案收藏用户数
        /// </summary>
        [XmlElement("tips_collect_uv")]
        public long TipsCollectUv { get; set; }

        /// <summary>
        /// 昨日收藏引导文案曝光用户数
        /// </summary>
        [XmlElement("tips_expo_uv")]
        public long TipsExpoUv { get; set; }

        /// <summary>
        /// 截止到当日累计小程序收藏人数
        /// </summary>
        [XmlElement("total_app_collect_cnt")]
        public long TotalAppCollectCnt { get; set; }

        /// <summary>
        /// 时间段内累计小程序访问人数
        /// </summary>
        [XmlElement("total_app_uv")]
        public long TotalAppUv { get; set; }

        /// <summary>
        /// 时间段内收藏引导文案收藏转化率，数据为小数字符串类型，取小数点后两位，单位为百分比。
        /// </summary>
        [XmlElement("total_tips_collect_rate")]
        public string TotalTipsCollectRate { get; set; }

        /// <summary>
        /// 时间段内累计收藏引导文案收藏用户数
        /// </summary>
        [XmlElement("total_tips_collect_uv")]
        public long TotalTipsCollectUv { get; set; }

        /// <summary>
        /// 时间段内累计收藏引导文案曝光用户数
        /// </summary>
        [XmlElement("total_tips_expo_uv")]
        public long TotalTipsExpoUv { get; set; }
    }
}
