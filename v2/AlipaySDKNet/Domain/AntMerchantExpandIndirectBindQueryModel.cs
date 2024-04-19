using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectBindQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectBindQueryModel : AopObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// smid传入后，传入的partner_id无效 smid和partner_id二选一必填
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
