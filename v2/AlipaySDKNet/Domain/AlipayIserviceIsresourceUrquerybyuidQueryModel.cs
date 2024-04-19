using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceUrquerybyuidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceUrquerybyuidQueryModel : AopObject
    {
        /// <summary>
        /// 小二的2088账号
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }
    }
}
