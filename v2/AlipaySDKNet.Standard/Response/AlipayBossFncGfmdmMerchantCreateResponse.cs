using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfmdmMerchantCreateResponse.
    /// </summary>
    public class AlipayBossFncGfmdmMerchantCreateResponse : AopResponse
    {
        /// <summary>
        /// 客商主数据ID
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
