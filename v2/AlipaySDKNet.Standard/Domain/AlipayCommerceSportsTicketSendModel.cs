using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsTicketSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsTicketSendModel : AopObject
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 场馆所属城市编号
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 运动项目分项
        /// </summary>
        [XmlElement("discipline")]
        public string Discipline { get; set; }

        /// <summary>
        /// 英文运动项目分项
        /// </summary>
        [XmlElement("discipline_en")]
        public string DisciplineEn { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 同步时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 开赛时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }

        /// <summary>
        /// 赛事场馆id
        /// </summary>
        [XmlElement("venue_id")]
        public string VenueId { get; set; }

        /// <summary>
        /// 观赛地点
        /// </summary>
        [XmlElement("venue_name")]
        public string VenueName { get; set; }

        /// <summary>
        /// 英文观赛地点
        /// </summary>
        [XmlElement("venue_name_en")]
        public string VenueNameEn { get; set; }
    }
}
