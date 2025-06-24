using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentZstInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentZstInfoDTO : AopObject
    {
        /// <summary>
        /// 服务商模式。签约资商通直付通平台商分账产品后，下单时传入平台模式 PLATFORM，smid必传；此模式下支持服务商派单模式
        /// </summary>
        [XmlElement("service_provider_model")]
        public string ServiceProviderModel { get; set; }
    }
}
