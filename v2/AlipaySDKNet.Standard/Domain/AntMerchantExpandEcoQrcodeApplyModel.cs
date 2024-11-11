using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandEcoQrcodeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandEcoQrcodeApplyModel : AopObject
    {
        /// <summary>
        /// 支付宝物料通码code
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 参数是用于发码时的幂等校验，如果参数相同则会发相同的码
        /// </summary>
        [XmlElement("idempotent_num")]
        public string IdempotentNum { get; set; }
    }
}
