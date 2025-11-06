using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFGestationStr Data Structure.
    /// </summary>
    [Serializable]
    public class HDFGestationStr : AopObject
    {
        /// <summary>
        /// 添加时间
        /// </summary>
        [XmlElement("add_time")]
        public string AddTime { get; set; }

        /// <summary>
        /// 预产期
        /// </summary>
        [XmlElement("expected_date")]
        public string ExpectedDate { get; set; }

        /// <summary>
        /// 妊娠史描述
        /// </summary>
        [XmlElement("gestation_str")]
        public string GestationStr { get; set; }

        /// <summary>
        /// 是否孕期（是/否)
        /// </summary>
        [XmlElement("is_gestation")]
        public string IsGestation { get; set; }
    }
}
