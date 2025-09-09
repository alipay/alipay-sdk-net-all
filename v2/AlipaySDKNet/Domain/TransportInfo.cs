using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransportInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TransportInfo : AopObject
    {
        /// <summary>
        /// 创作搬运文件信息
        /// </summary>
        [XmlElement("afts_url")]
        public string AftsUrl { get; set; }

        /// <summary>
        /// 搬运信息生成批次号
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }
    }
}
