using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistributionBuyerAddressModifyApplyInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DistributionBuyerAddressModifyApplyInfoDTO : AopObject
    {
        /// <summary>
        /// 申请修改的地址
        /// </summary>
        [XmlElement("address")]
        public DistributionMerchantAddressDTO Address { get; set; }

        /// <summary>
        /// 修改前的买家收货地址
        /// </summary>
        [XmlElement("source_address")]
        public DistributionMerchantAddressDTO SourceAddress { get; set; }
    }
}
