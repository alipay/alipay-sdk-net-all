using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiCvRsXytileGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiCvRsXytileGetModel : AopObject
    {
        /// <summary>
        /// 101：玉米 115：大豆 147：水稻
        /// </summary>
        [XmlElement("crow_type")]
        public string CrowType { get; set; }

        /// <summary>
        /// 数据时间
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 指标类型
        /// </summary>
        [XmlElement("index")]
        public string Index { get; set; }

        /// <summary>
        /// 瓦片x
        /// </summary>
        [XmlElement("x")]
        public string X { get; set; }

        /// <summary>
        /// 瓦片y
        /// </summary>
        [XmlElement("y")]
        public string Y { get; set; }

        /// <summary>
        /// 瓦片z
        /// </summary>
        [XmlElement("z")]
        public string Z { get; set; }
    }
}
