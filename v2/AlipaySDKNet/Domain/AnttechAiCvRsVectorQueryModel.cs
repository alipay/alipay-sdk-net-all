using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiCvRsVectorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiCvRsVectorQueryModel : AopObject
    {
        /// <summary>
        /// 项目id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 瓦片横坐标
        /// </summary>
        [XmlElement("x")]
        public string X { get; set; }

        /// <summary>
        /// 瓦片横坐标
        /// </summary>
        [XmlElement("y")]
        public string Y { get; set; }

        /// <summary>
        /// 瓦片级别
        /// </summary>
        [XmlElement("z")]
        public string Z { get; set; }
    }
}
