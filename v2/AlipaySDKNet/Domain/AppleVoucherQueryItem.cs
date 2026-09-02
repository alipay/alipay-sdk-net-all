using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppleVoucherQueryItem Data Structure.
    /// </summary>
    [Serializable]
    public class AppleVoucherQueryItem : AopObject
    {
        /// <summary>
        /// 券额度，单位分
        /// </summary>
        [XmlElement("credit_amount")]
        public string CreditAmount { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 额度券实例号
        /// </summary>
        [XmlElement("instance_no")]
        public string InstanceNo { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// valid表示生效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
