using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandDigitalgroupApplyCreateResponse.
    /// </summary>
    public class AntMerchantExpandDigitalgroupApplyCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请单ID，表示唯一请求，可以追踪结果
        /// </summary>
        [XmlElement("apply_order_id")]
        public string ApplyOrderId { get; set; }
    }
}
