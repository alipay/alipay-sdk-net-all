using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserLogonidMaskedQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserLogonidMaskedQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID，不可为空，一次最多传10个
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
