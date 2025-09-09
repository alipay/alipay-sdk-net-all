using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CheckInUnusualNotifyDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CheckInUnusualNotifyDetail : AopObject
    {
        /// <summary>
        /// 已打卡人数。
        /// </summary>
        [XmlElement("checked_total")]
        public long CheckedTotal { get; set; }

        /// <summary>
        /// 推送时间。
        /// </summary>
        [XmlElement("gmt_push")]
        public string GmtPush { get; set; }

        /// <summary>
        /// 由支付宝为学校生产的唯一编号。
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 学校名称。
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 总人数。
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 未打卡人数。
        /// </summary>
        [XmlElement("unchecked_total")]
        public long UncheckedTotal { get; set; }
    }
}
