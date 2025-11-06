using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteopOpAuthProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InteopOpAuthProductInfo : AopObject
    {
        /// <summary>
        /// 产品对应权限集code
        /// </summary>
        [XmlArray("permission_codes")]
        [XmlArrayItem("string")]
        public List<string> PermissionCodes { get; set; }

        /// <summary>
        /// 商家券
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
