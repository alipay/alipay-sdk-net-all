using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupNoticeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupNoticeModifyModel : AopObject
    {
        /// <summary>
        /// 群组id列表
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 群公告
        /// </summary>
        [XmlElement("notice")]
        public string Notice { get; set; }
    }
}
