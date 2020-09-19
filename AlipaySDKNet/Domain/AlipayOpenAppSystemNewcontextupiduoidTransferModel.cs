using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppSystemNewcontextupiduoidTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppSystemNewcontextupiduoidTransferModel : AopObject
    {
        /// <summary>
        /// 101
        /// </summary>
        [XmlElement("param_one")]
        public string ParamOne { get; set; }
    }
}
