using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyPraviteTestForUploadComplexInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RainyPraviteTestForUploadComplexInfo : AopObject
    {
        /// <summary>
        /// 支付宝用户的demo。
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }
    }
}
