using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RegisterDate Data Structure.
    /// </summary>
    [Serializable]
    public class RegisterDate : AopObject
    {
        /// <summary>
        /// 截止日期 格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 开始日期， 格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
