using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockBizQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockBizQueryModel : AopObject
    {
        /// <summary>
        /// 业务编码
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
