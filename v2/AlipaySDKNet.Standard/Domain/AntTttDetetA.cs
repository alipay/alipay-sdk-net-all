using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntTttDetetA Data Structure.
    /// </summary>
    [Serializable]
    public class AntTttDetetA : AopObject
    {
        /// <summary>
        /// 描述地址
        /// </summary>
        [XmlElement("addr")]
        public string Addr { get; set; }
    }
}
