using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserMobilebillListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMobilebillListQueryModel : AopObject
    {
        /// <summary>
        /// 查询范围-结束时间，开始和结束时间间隔不能大于31天
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询范围-开始时间，开始和结束时间间隔不能大于31天
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 用户uid，仅做路由，不实际消费
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户uid，仅做路由，不实际消费
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
