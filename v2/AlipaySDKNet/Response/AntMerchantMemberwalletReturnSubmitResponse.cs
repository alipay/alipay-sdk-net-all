using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantMemberwalletReturnSubmitResponse.
    /// </summary>
    public class AntMerchantMemberwalletReturnSubmitResponse : AopResponse
    {
        /// <summary>
        /// 退款成功的卡余额（单位：元）
        /// </summary>
        [XmlElement("actual_return_amount")]
        public string ActualReturnAmount { get; set; }

        /// <summary>
        /// 退款成功的卡余额（单位：元）
        /// </summary>
        [XmlElement("return_amount")]
        public string ReturnAmount { get; set; }
    }
}
