using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzSdkEventDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class YpzSdkEventDetailDTO : AopObject
    {
        /// <summary>
        /// 事件编码
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 事件总量
        /// </summary>
        [XmlElement("event_count")]
        public string EventCount { get; set; }

        /// <summary>
        /// 事件结果描述
        /// </summary>
        [XmlElement("event_description")]
        public string EventDescription { get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [XmlElement("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// 事件发生日期
        /// </summary>
        [XmlElement("event_occur_date")]
        public string EventOccurDate { get; set; }

        /// <summary>
        /// 事件更新日期
        /// </summary>
        [XmlElement("event_update_date")]
        public string EventUpdateDate { get; set; }

        /// <summary>
        /// 大于10min的事件数量
        /// </summary>
        [XmlElement("greater_than_10m")]
        public string GreaterThan10m { get; set; }

        /// <summary>
        /// 大于15秒的事件数量
        /// </summary>
        [XmlElement("greater_than_15s")]
        public string GreaterThan15s { get; set; }

        /// <summary>
        /// 大于1h的事件数据量
        /// </summary>
        [XmlElement("greater_than_1h")]
        public string GreaterThan1h { get; set; }

        /// <summary>
        /// 大于1min的事件数量
        /// </summary>
        [XmlElement("greater_than_1m")]
        public string GreaterThan1m { get; set; }

        /// <summary>
        /// 大于 30min 的事件数量
        /// </summary>
        [XmlElement("greater_than_30m")]
        public string GreaterThan30m { get; set; }

        /// <summary>
        /// 大于5秒的事件数量
        /// </summary>
        [XmlElement("greater_than_5s")]
        public string GreaterThan5s { get; set; }

        /// <summary>
        /// 小于 0s 的事件数量
        /// </summary>
        [XmlElement("less_than_0s")]
        public string LessThan0s { get; set; }

        /// <summary>
        /// 小于负1s的事件数量
        /// </summary>
        [XmlElement("less_than_negative_1s")]
        public string LessThanNegative1s { get; set; }

        /// <summary>
        /// 医疗机构名称
        /// </summary>
        [XmlElement("medical_institution_name")]
        public string MedicalInstitutionName { get; set; }

        /// <summary>
        /// 负1s到10s区间内的事件数量
        /// </summary>
        [XmlElement("range_negative_1_to_10_s")]
        public string RangeNegative1To10S { get; set; }

        /// <summary>
        /// 负1s到15s区间内的事件数量
        /// </summary>
        [XmlElement("range_negative_1_to_15_s")]
        public string RangeNegative1To15S { get; set; }

        /// <summary>
        /// [-1s,5s] 区间内的事件数量
        /// </summary>
        [XmlElement("range_negative_1_to_5_s")]
        public string RangeNegative1To5S { get; set; }

        /// <summary>
        /// 负1s到10s区间内的事件占比
        /// </summary>
        [XmlElement("rate_negative_1_to_10_s")]
        public string RateNegative1To10S { get; set; }

        /// <summary>
        /// 负1s到15s区间内的事件占比
        /// </summary>
        [XmlElement("rate_negative_1_to_15_s")]
        public string RateNegative1To15S { get; set; }

        /// <summary>
        /// 负1s到5s区间内事件占比
        /// </summary>
        [XmlElement("rate_negative_1_to_5_s")]
        public string RateNegative1To5S { get; set; }

        /// <summary>
        /// 医疗机构统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
