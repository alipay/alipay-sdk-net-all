using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserSportsplayPathBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSportsplayPathBatchqueryModel : AopObject
    {
        /// <summary>
        /// 路线id
        /// </summary>
        [XmlElement("path_id")]
        public string PathId { get; set; }
    }
}
