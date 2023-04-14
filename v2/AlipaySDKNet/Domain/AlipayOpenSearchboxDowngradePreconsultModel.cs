using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchboxDowngradePreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchboxDowngradePreconsultModel : AopObject
    {
        /// <summary>
        /// 搜索直达boxId
        /// </summary>
        [XmlElement("box_id")]
        public string BoxId { get; set; }
    }
}
