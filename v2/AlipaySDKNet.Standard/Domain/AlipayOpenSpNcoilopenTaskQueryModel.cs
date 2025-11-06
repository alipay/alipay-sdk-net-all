using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNcoilopenTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNcoilopenTaskQueryModel : AopObject
    {
        /// <summary>
        /// 流水id，通过调用alipay.open.sp.ncoilopen.reference.create接口返回值中获取reference_id
        /// </summary>
        [XmlElement("reference_id")]
        public string ReferenceId { get; set; }
    }
}
