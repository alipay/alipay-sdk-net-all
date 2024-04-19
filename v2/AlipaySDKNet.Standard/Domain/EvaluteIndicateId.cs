using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EvaluteIndicateId Data Structure.
    /// </summary>
    [Serializable]
    public class EvaluteIndicateId : AopObject
    {
        /// <summary>
        /// 商户指标id
        /// </summary>
        [XmlElement("isv_indicate_id")]
        public string IsvIndicateId { get; set; }
    }
}
