using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceExtInfoMap Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceExtInfoMap : AopObject
    {
        /// <summary>
        /// 服务图片
        /// </summary>
        [XmlElement("service_pic")]
        public string ServicePic { get; set; }
    }
}
