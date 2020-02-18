using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PublicMsgKeyword Data Structure.
    /// </summary>
    [Serializable]
    public class PublicMsgKeyword : AopObject
    {
        /// <summary>
        /// 模板关键字名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
