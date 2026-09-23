using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalYpzPhonequalityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalYpzPhonequalityQueryModel : AopObject
    {
        /// <summary>
        /// 查询结束时间（事件发生时间/统计时间）
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询开始时间（事件发生时间/统计时间）
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 医疗机构统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
