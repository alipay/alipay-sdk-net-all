using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingEquityCustbilldownloadtaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingEquityCustbilldownloadtaskCreateModel : AopObject
    {
        /// <summary>
        /// 账单交易开始结束时间yyyyMMdd 的格式
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 摩斯机构id
        /// </summary>
        [XmlElement("inst_morse_id")]
        public string InstMorseId { get; set; }

        /// <summary>
        /// 账单交易开始时间 yyyyMMdd的格式
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
