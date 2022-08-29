using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignRecordLogVO Data Structure.
    /// </summary>
    [Serializable]
    public class SignRecordLogVO : AopObject
    {
        /// <summary>
        /// 签约的协议版本
        /// </summary>
        [XmlElement("s_version")]
        public string SVersion { get; set; }

        /// <summary>
        /// 签约动作 S/U
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 签约/解约日期
        /// </summary>
        [XmlElement("trans_date")]
        public string TransDate { get; set; }
    }
}
