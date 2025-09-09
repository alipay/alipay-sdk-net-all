using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandAddressQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAddressQueryModel : AopObject
    {
        /// <summary>
        /// 数组类型,包含多个address_id,可查询多个商家地址address_id下面对应的商家地址信息 [2024051300502055000064955576,2024051300502055000065014598]
        /// </summary>
        [XmlArray("address_ids")]
        [XmlArrayItem("string")]
        public List<string> AddressIds { get; set; }
    }
}
