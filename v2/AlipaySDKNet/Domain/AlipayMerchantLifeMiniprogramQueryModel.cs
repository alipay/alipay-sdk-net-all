using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantLifeMiniprogramQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantLifeMiniprogramQueryModel : AopObject
    {
        /// <summary>
        /// request+否+第三方服务商业务流程ID+无+我方生成
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
