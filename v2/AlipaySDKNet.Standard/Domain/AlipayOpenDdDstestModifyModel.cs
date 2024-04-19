using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenDdDstestModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenDdDstestModifyModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address_open_id")]
        public string AddressOpenId { get; set; }
    }
}
