using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspFaceimgstateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspFaceimgstateQueryModel : AopObject
    {
        /// <summary>
        /// 刷脸产生的ftoken
        /// </summary>
        [XmlElement("ftoken")]
        public string Ftoken { get; set; }
    }
}
