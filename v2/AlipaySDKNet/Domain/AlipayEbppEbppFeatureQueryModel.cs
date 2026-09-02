using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppFeatureQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppFeatureQueryModel : AopObject
    {
        /// <summary>
        /// 批次id 即文件名
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }
    }
}
