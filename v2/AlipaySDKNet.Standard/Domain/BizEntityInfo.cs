using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizEntityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BizEntityInfo : AopObject
    {
        /// <summary>
        /// 门店门头照image链接
        /// </summary>
        [XmlElement("store_door_img")]
        public string StoreDoorImg { get; set; }
    }
}
