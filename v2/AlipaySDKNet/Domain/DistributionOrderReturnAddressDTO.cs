using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistributionOrderReturnAddressDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DistributionOrderReturnAddressDTO : AopObject
    {
        /// <summary>
        /// 地址ID，通过地址管理接口维护和获取
        /// </summary>
        [XmlElement("address_id")]
        public string AddressId { get; set; }
    }
}
