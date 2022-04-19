using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinEquityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FinEquityInfo : AopObject
    {
        /// <summary>
        /// 权益有效期的结束时间，如不传则以约定时间为准
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 第三方权益券码
        /// </summary>
        [XmlElement("equity_code")]
        public string EquityCode { get; set; }

        /// <summary>
        /// 发放的第三方权益的数量，默认为1
        /// </summary>
        [XmlElement("equity_num")]
        public long EquityNum { get; set; }

        /// <summary>
        /// 发放的第三方权益的类型
        /// </summary>
        [XmlElement("equity_type")]
        public string EquityType { get; set; }

        /// <summary>
        /// 第三方权益产品号
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 权益有效期的开始时间，默认为当前
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 权益状态。权益状态（有效VALID，已使用USED，已过期EXPIRED，已退单REFUND，不可用INVALID）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 核销情况。key值为约定信息。悦途贵宾厅约定字段：use_time，region_name，hall_name，position
        /// </summary>
        [XmlElement("verification_info")]
        public QYBMapInfo VerificationInfo { get; set; }
    }
}
