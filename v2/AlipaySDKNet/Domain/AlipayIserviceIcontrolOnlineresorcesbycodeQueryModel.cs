using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIcontrolOnlineresorcesbycodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIcontrolOnlineresorcesbycodeQueryModel : AopObject
    {
        /// <summary>
        /// 业务包code
        /// </summary>
        [XmlElement("biz_package_code")]
        public string BizPackageCode { get; set; }
    }
}
