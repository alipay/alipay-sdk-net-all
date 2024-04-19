using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappServiceconfigModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMiniappServiceconfigModifyModel : AopObject
    {
        /// <summary>
        /// 云客服是否在小程序首页透出，true-开启，false-不开启
        /// </summary>
        [XmlElement("home_open")]
        public bool HomeOpen { get; set; }

        /// <summary>
        /// 客服方式，目前支持ANTCLOUD-云客服
        /// </summary>
        [XmlElement("service_config")]
        public string ServiceConfig { get; set; }
    }
}
