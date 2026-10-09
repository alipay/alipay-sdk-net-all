using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NfcPointRefreshData Data Structure.
    /// </summary>
    [Serializable]
    public class NfcPointRefreshData : AopObject
    {
        /// <summary>
        /// 本接口仅支持text氛围
        /// </summary>
        [XmlElement("atmosphere")]
        public string Atmosphere { get; set; }

        /// <summary>
        /// 百分比模式下的消耗值
        /// </summary>
        [XmlElement("consume_value")]
        public long ConsumeValue { get; set; }

        /// <summary>
        /// 埋点信息
        /// </summary>
        [XmlElement("event_tracking_module")]
        public NfcPointRefreshEventTracking EventTrackingModule { get; set; }

        /// <summary>
        /// 曝光规则
        /// </summary>
        [XmlElement("exposure_rule")]
        public NfcPointRefreshExposureRule ExposureRule { get; set; }

        /// <summary>
        /// 本接口固定为立减进度条海报
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 进度匹配文案
        /// </summary>
        [XmlElement("match_text")]
        public NfcPointRefreshMatchText MatchText { get; set; }

        /// <summary>
        /// 立减进度条海报的补充说明文案
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 海报素材展示点位：paying_discount为支付中，after_pay_voucher为支付后
        /// </summary>
        [XmlElement("point_code")]
        public string PointCode { get; set; }

        /// <summary>
        /// 进度条配置
        /// </summary>
        [XmlElement("process_setting")]
        public NfcPointRefreshProcessSetting ProcessSetting { get; set; }

        /// <summary>
        /// 当前展示进度；show_type为percent时单位为%，为count时单位为份
        /// </summary>
        [XmlElement("process_value")]
        public long ProcessValue { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("resources")]
        [XmlArrayItem("nfc_point_refresh_resource")]
        public List<NfcPointRefreshResource> Resources { get; set; }

        /// <summary>
        /// 展示文案
        /// </summary>
        [XmlElement("show_text")]
        public NfcPointRefreshShowText ShowText { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("voice_resources")]
        [XmlArrayItem("nfc_point_refresh_voice_resource")]
        public List<NfcPointRefreshVoiceResource> VoiceResources { get; set; }
    }
}
