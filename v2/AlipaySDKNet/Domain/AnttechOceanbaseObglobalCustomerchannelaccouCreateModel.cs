using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalCustomerchannelaccouCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalCustomerchannelaccouCreateModel : AopObject
    {
        /// <summary>
        /// 创建客户关联渠道账号请求体
        /// </summary>
        [XmlElement("create_customer_channel_account_request")]
        public CreateCustomerChannelAccountRequest CreateCustomerChannelAccountRequest { get; set; }
    }
}
