using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResourceUserDataVO Data Structure.
    /// </summary>
    [Serializable]
    public class ResourceUserDataVO : AopObject
    {
        /// <summary>
        /// 用户画像的类别
        /// </summary>
        [XmlElement("profile_type")]
        public string ProfileType { get; set; }

        /// <summary>
        /// 用户画像值
        /// </summary>
        [XmlElement("profile_value")]
        public string ProfileValue { get; set; }

        /// <summary>
        /// 统计日期
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 用户数量，出于隐私考虑，该数据和实际数据有微小的差异，但是不影响总体数据准确度。
        /// </summary>
        [XmlElement("user_cnt")]
        public long UserCnt { get; set; }

        /// <summary>
        /// 用户占比。出于隐私考虑，该数据和实际数据有微小的差异，但是不影响总体数据准确度。
        /// </summary>
        [XmlElement("user_ratio")]
        public string UserRatio { get; set; }
    }
}
