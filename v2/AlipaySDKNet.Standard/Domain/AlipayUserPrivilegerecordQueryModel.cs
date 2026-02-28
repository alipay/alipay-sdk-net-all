using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserPrivilegerecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPrivilegerecordQueryModel : AopObject
    {
        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
