using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FcStarRobotSessionPage Data Structure.
    /// </summary>
    [Serializable]
    public class FcStarRobotSessionPage : AopObject
    {
        /// <summary>
        /// 总记录条数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 每页显示记录条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 会话列表
        /// </summary>
        [XmlArray("result_obj")]
        [XmlArrayItem("fc_star_robot_session")]
        public List<FcStarRobotSession> ResultObj { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
