using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QualInstanceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class QualInstanceDTO : AopObject
    {
        /// <summary>
        /// 资格实例生效时间
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 资格实例申领时间
        /// </summary>
        [XmlElement("gmt_apply")]
        public string GmtApply { get; set; }

        /// <summary>
        /// 资格实例失效时间
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 资格实例核销时间
        /// </summary>
        [XmlElement("gmt_use")]
        public string GmtUse { get; set; }

        /// <summary>
        /// 资格编号ID
        /// </summary>
        [XmlElement("qual_id")]
        public string QualId { get; set; }

        /// <summary>
        /// 资格实例ID
        /// </summary>
        [XmlElement("qual_instance_id")]
        public string QualInstanceId { get; set; }

        /// <summary>
        /// 资格实例状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
