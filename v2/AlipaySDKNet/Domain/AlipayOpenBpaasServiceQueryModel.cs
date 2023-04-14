using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenBpaasServiceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenBpaasServiceQueryModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }
    }
}
