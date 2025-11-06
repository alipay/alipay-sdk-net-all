using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinKeyWord Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinKeyWord : AopObject
    {
        /// <summary>
        /// 用于在PDF中检索签名位置使用的关键字
        /// </summary>
        [XmlElement("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 关键字所在的页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }
    }
}
