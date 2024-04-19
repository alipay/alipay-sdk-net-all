using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicUserExpressQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicUserExpressQueryModel : AopObject
    {
        /// <summary>
        /// 银行机构ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
