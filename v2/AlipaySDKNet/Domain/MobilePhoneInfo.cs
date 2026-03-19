using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MobilePhoneInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MobilePhoneInfo : AopObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 运营商缩写
        /// </summary>
        [XmlElement("operator_abbr")]
        public string OperatorAbbr { get; set; }

        /// <summary>
        /// 运营商名称
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 号段
        /// </summary>
        [XmlElement("segment_number")]
        public string SegmentNumber { get; set; }

        /// <summary>
        /// 子运营商
        /// </summary>
        [XmlElement("sub_operator")]
        public string SubOperator { get; set; }

        /// <summary>
        /// 区号
        /// </summary>
        [XmlElement("tel_code")]
        public string TelCode { get; set; }
    }
}
