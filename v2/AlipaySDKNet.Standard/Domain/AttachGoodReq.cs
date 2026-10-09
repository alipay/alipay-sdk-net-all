using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttachGoodReq Data Structure.
    /// </summary>
    [Serializable]
    public class AttachGoodReq : AopObject
    {
        /// <summary>
        /// id
        /// </summary>
        [XmlElement("attach_good_id")]
        public string AttachGoodId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }
    }
}
