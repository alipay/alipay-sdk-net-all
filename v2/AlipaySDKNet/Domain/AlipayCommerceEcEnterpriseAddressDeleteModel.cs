using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseAddressDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseAddressDeleteModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("address_id_list")]
        [XmlArrayItem("string")]
        public List<string> AddressIdList { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
