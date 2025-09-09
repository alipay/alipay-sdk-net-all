using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QrcodeWhiteList Data Structure.
    /// </summary>
    [Serializable]
    public class QrcodeWhiteList : AopObject
    {
        /// <summary>
        /// 小程序id或域名
        /// </summary>
        [XmlElement("app_id_or_domain")]
        public string AppIdOrDomain { get; set; }

        /// <summary>
        /// 类型，H5:H5, 小程序：MINI_APP
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
