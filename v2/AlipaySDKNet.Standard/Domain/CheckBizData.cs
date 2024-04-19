using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CheckBizData Data Structure.
    /// </summary>
    [Serializable]
    public class CheckBizData : AopObject
    {
        /// <summary>
        /// 人脸比对id
        /// </summary>
        [XmlElement("zim_id")]
        public string ZimId { get; set; }
    }
}
