using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHmtaskRecordsummaryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHmtaskRecordsummaryQueryModel : AopObject
    {
        /// <summary>
        /// 结束日期，格式：yyyy-mm-dd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 记录类型
        /// </summary>
        [XmlElement("record_type")]
        public string RecordType { get; set; }

        /// <summary>
        /// 开始日期，格式：yyyy-mm-dd
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 用户userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
