using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantMemberwalletReturnConsultResponse.
    /// </summary>
    public class AntMerchantMemberwalletReturnConsultResponse : AopResponse
    {
        /// <summary>
        /// 实际可退卡余额（单位：元）
        /// </summary>
        [XmlElement("actual_return_amount")]
        public string ActualReturnAmount { get; set; }

        /// <summary>
        /// 可退卡余额（单位：元）
        /// </summary>
        [XmlElement("return_amount")]
        public string ReturnAmount { get; set; }
    }
}
