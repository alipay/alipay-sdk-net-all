using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenBrandAuthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenBrandAuthQueryModel : AopObject
    {
        /// <summary>
        /// true:只返回已授权,false:返回已授权+未授权
        /// </summary>
        [XmlElement("authorized")]
        public bool Authorized { get; set; }

        /// <summary>
        /// true:需要,false:不需要
        /// </summary>
        [XmlElement("need_app")]
        public bool NeedApp { get; set; }
    }
}
