using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcoMockGroupInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcoMockGroupInfo : AopObject
    {
        /// <summary>
        /// appId
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 挡板数
        /// </summary>
        [XmlElement("mock_count")]
        public long MockCount { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 分组状态: INUSE/UNUSE
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
