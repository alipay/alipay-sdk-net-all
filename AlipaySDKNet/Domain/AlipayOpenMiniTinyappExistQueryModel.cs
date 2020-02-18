using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniTinyappExistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTinyappExistQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝账号ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
