using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossRelatedCompanyConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossRelatedCompanyConsultModel : AopObject
    {
        /// <summary>
        /// 咨询发生时间（单位；毫秒） 若无指定时间，使用系统当前时间。
        /// </summary>
        [XmlElement("biz_time_in_mills")]
        public long BizTimeInMills { get; set; }

        /// <summary>
        /// 咨询的关联方公司生效时间是否按照整月生效。 若无关联方识别整月对齐需求，传false。
        /// </summary>
        [XmlElement("is_whole_month_valid")]
        public bool IsWholeMonthValid { get; set; }

        /// <summary>
        /// 咨询类型：PID/UID/MID/CID/NAME/OU
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 根据咨询类型传入相应的咨询值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
