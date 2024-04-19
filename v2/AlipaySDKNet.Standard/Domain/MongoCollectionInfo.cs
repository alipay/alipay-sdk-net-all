using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MongoCollectionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MongoCollectionInfo : AopObject
    {
        /// <summary>
        /// 集合名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
