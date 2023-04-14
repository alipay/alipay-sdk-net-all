using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserSocialinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSocialinfoQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID，不可为空，最大一次传递10个
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
