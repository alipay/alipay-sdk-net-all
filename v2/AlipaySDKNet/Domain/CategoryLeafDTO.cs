using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CategoryLeafDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryLeafDTO : AopObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
