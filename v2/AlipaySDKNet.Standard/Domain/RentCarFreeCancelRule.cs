using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarFreeCancelRule Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarFreeCancelRule : AopObject
    {
        /// <summary>
        /// 免费取消截止时间。free_type=1时使用此字段
        /// </summary>
        [XmlElement("free_date")]
        public string FreeDate { get; set; }

        /// <summary>
        /// 可免费取消的时间，单位分钟。用户free_type=2时
        /// </summary>
        [XmlElement("free_minutes")]
        public long FreeMinutes { get; set; }

        /// <summary>
        /// 免费取消共4种类型： 1、指定时间前可免费取消（xxxx年xx月xx日xx时xx分前可免费取消） 2、支付后一段时间内可免费取消（支付后15分钟内免费取消） 3、取车前免费取消 4、不能免费取消
        /// </summary>
        [XmlElement("free_type")]
        public long FreeType { get; set; }
    }
}
