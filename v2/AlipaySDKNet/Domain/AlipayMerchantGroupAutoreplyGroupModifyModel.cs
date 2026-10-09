using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupAutoreplyGroupModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupAutoreplyGroupModifyModel : AopObject
    {
        /// <summary>
        /// 自动回复id
        /// </summary>
        [XmlElement("autoreply_id")]
        public string AutoreplyId { get; set; }

        /// <summary>
        /// 是否全局生效
        /// </summary>
        [XmlElement("global_valid")]
        public bool GlobalValid { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("group_id_list")]
        [XmlArrayItem("string")]
        public List<string> GroupIdList { get; set; }
    }
}
