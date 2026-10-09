using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchboxUpgradePreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchboxUpgradePreconsultModel : AopObject
    {
        /// <summary>
        /// 搜索直达boxId
        /// </summary>
        [XmlElement("box_id")]
        public string BoxId { get; set; }
    }
}
