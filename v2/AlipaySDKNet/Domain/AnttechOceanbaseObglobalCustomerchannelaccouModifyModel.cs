using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalCustomerchannelaccouModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalCustomerchannelaccouModifyModel : AopObject
    {
        /// <summary>
        /// 更新客户关联渠道账号请求体
        /// </summary>
        [XmlElement("update_customer_channel_account_request")]
        public UpdateCustomerChannelAccountRequest UpdateCustomerChannelAccountRequest { get; set; }
    }
}
