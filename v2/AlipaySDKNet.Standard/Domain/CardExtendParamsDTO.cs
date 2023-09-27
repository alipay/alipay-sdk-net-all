using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardExtendParamsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CardExtendParamsDTO : AopObject
    {
        /// <summary>
        /// 是否需要开通钱包
        /// </summary>
        [XmlElement("open_wallet")]
        public string OpenWallet { get; set; }
    }
}
