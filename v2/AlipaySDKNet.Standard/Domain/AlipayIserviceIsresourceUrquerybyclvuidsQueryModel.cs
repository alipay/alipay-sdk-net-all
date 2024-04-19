using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceUrquerybyclvuidsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceUrquerybyclvuidsQueryModel : AopObject
    {
        /// <summary>
        /// 旧平台userid列表
        /// </summary>
        [XmlArray("clv_user_ids")]
        [XmlArrayItem("string")]
        public List<string> ClvUserIds { get; set; }
    }
}
