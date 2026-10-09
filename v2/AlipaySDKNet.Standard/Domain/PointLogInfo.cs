using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PointLogInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PointLogInfo : AopObject
    {
        /// <summary>
        /// 积分明细数量
        /// </summary>
        [XmlElement("point_log_amount")]
        public string PointLogAmount { get; set; }

        /// <summary>
        /// 积分明细时间 格式 “yyyy.MM.dd HH:mm:ss”
        /// </summary>
        [XmlElement("point_log_date")]
        public string PointLogDate { get; set; }

        /// <summary>
        /// 积分明细id，唯一标识
        /// </summary>
        [XmlElement("point_log_id")]
        public string PointLogId { get; set; }

        /// <summary>
        /// 积分明细标题
        /// </summary>
        [XmlElement("point_log_title")]
        public string PointLogTitle { get; set; }
    }
}
