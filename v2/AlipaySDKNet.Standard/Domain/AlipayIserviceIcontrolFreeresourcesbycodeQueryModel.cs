using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIcontrolFreeresourcesbycodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIcontrolFreeresourcesbycodeQueryModel : AopObject
    {
        /// <summary>
        /// 业务包code
        /// </summary>
        [XmlElement("biz_package_code")]
        public string BizPackageCode { get; set; }
    }
}
