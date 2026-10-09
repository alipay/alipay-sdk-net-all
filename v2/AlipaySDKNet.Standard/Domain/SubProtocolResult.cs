using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubProtocolResult Data Structure.
    /// </summary>
    [Serializable]
    public class SubProtocolResult : AopObject
    {
        /// <summary>
        /// 与蚂蚁业务方约定的类型，同时约定$orgCode值
        /// </summary>
        [XmlElement("protocol_type")]
        public string ProtocolType { get; set; }

        /// <summary>
        /// 业务请求结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 订阅个股还是全部，ALL表示全部，SYMBOL表示个股
        /// </summary>
        [XmlElement("sign_content")]
        public string SignContent { get; set; }

        /// <summary>
        /// 股票市场上的代码+市场组合的代码
        /// </summary>
        [XmlArray("symbols")]
        [XmlArrayItem("string")]
        public List<string> Symbols { get; set; }
    }
}
