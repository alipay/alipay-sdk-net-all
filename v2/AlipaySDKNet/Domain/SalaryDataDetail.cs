using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SalaryDataDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SalaryDataDetail : AopObject
    {
        /// <summary>
        /// 指标名明细
        /// </summary>
        [XmlElement("data_detail")]
        public string DataDetail { get; set; }

        /// <summary>
        /// 技能组ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
