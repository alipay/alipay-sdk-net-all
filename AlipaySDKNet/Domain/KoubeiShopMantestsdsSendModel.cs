using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiShopMantestsdsSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopMantestsdsSendModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("opopo")]
        public string Opopo { get; set; }
    }
}
