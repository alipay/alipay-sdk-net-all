using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpBlueseaactivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpBlueseaactivityQueryModel : AopObject
    {
        /// <summary>
        /// 申请单Id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
