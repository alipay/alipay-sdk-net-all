using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceFeeQueryResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasFaceFeeQueryResponse : AopResponse
    {
        /// <summary>
        /// certify_id：要查询计费状态的单据 charge_type：计费结果状态，FAIL_NOT_CHARGE，表示该certify_id不计费；CHARGE，表示该certify_id计费 error_code：目前暂时只有INVALID_CERTIFY_ID，表示certify_id无效。
        /// </summary>
        [XmlArray("fee_info")]
        [XmlArrayItem("merchant_charge_info")]
        public List<MerchantChargeInfo> FeeInfo { get; set; }
    }
}
