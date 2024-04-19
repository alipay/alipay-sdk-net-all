using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutOfConfigGoodsResult Data Structure.
    /// </summary>
    [Serializable]
    public class OutOfConfigGoodsResult : AopObject
    {
        /// <summary>
        /// 算法id
        /// </summary>
        [XmlElement("algorithm_id")]
        public string AlgorithmId { get; set; }
    }
}
