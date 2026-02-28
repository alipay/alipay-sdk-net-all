using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MyArray Data Structure.
    /// </summary>
    [Serializable]
    public class MyArray : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlArray("aa")]
        [XmlArrayItem("string")]
        public List<string> Aa { get; set; }
    }
}
