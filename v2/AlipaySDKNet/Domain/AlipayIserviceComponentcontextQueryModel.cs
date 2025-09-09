using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceComponentcontextQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceComponentcontextQueryModel : AopObject
    {
        /// <summary>
        /// 一通服务的唯一ID，在服务拉起时，由方舟自动生成或者由渠道传入
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 查找的源组件code，方舟为插件颁发的唯一code
        /// </summary>
        [XmlElement("source_component_code")]
        public string SourceComponentCode { get; set; }

        /// <summary>
        /// 查找的目标组件的code，方舟颁发给插件的唯一code
        /// </summary>
        [XmlElement("target_component_code")]
        public string TargetComponentCode { get; set; }
    }
}
