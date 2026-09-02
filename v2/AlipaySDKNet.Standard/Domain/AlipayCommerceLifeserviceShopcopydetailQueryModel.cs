using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceShopcopydetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceShopcopydetailQueryModel : AopObject
    {
        /// <summary>
        /// 副本业务ID
        /// </summary>
        [XmlElement("copy_id")]
        public string CopyId { get; set; }
    }
}
