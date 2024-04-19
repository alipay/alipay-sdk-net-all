using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TbapiQueryAmountBizContent Data Structure.
    /// </summary>
    [Serializable]
    public class TbapiQueryAmountBizContent : AopObject
    {
        /// <summary>
        /// 查询指定额度产品组
        /// </summary>
        [XmlElement("amt_group")]
        public string AmtGroup { get; set; }

        /// <summary>
        /// 查询指定额度产品码
        /// </summary>
        [XmlArray("amt_prods")]
        [XmlArrayItem("string")]
        public List<string> AmtProds { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [XmlElement("request_from")]
        public string RequestFrom { get; set; }

        /// <summary>
        /// 请求场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
