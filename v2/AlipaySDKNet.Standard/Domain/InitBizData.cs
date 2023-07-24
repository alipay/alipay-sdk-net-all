using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InitBizData Data Structure.
    /// </summary>
    [Serializable]
    public class InitBizData : AopObject
    {
        /// <summary>
        /// 不可用核身产品
        /// </summary>
        [XmlElement("un_valid_prods")]
        public string UnValidProds { get; set; }
    }
}
