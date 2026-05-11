using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderExpoNfccheckinSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderExpoNfccheckinSubmitModel : AopObject
    {
        /// <summary>
        /// 活动code值
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 打卡点对应的id
        /// </summary>
        [XmlElement("check_place")]
        public string CheckPlace { get; set; }

        /// <summary>
        /// 打卡模板
        /// </summary>
        [XmlElement("check_template_type")]
        public string CheckTemplateType { get; set; }

        /// <summary>
        /// 自定义外部标识
        /// </summary>
        [XmlElement("external_place_mark")]
        public string ExternalPlaceMark { get; set; }

        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 请求来源（请求方）
        /// </summary>
        [XmlElement("request_src")]
        public string RequestSrc { get; set; }

        /// <summary>
        /// 方案配置code
        /// </summary>
        [XmlElement("solution_config_code")]
        public string SolutionConfigCode { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// user_id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
