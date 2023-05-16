using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiTradeBencftestRefuseModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeBencftestRefuseModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("wp")]
        public string Wp { get; set; }
    }
}
