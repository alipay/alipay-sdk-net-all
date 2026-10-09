using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIdeployShiftQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIdeployShiftQueryModel : AopObject
    {
        /// <summary>
        /// 结束时间，单位/ms，注意开始结束时间不能超过一天
        /// </summary>
        [XmlElement("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 星云租户下小二的唯一身份ID
        /// </summary>
        [XmlElement("nebula_user_id")]
        public string NebulaUserId { get; set; }

        /// <summary>
        /// 时间戳，单位/ms,注意开始结束时间不能超过一天
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }
    }
}
