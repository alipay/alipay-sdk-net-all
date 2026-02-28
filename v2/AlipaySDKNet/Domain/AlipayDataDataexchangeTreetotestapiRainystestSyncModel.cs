using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeTreetotestapiRainystestSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeTreetotestapiRainystestSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的demo。
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }
    }
}
