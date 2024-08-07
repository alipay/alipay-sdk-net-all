using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupgiftCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupgiftCreateModel : AopObject
    {
        /// <summary>
        /// 入群有礼列表。
        /// </summary>
        [XmlArray("group_gifts")]
        [XmlArrayItem("group_gift_v_o")]
        public List<GroupGiftVO> GroupGifts { get; set; }

        /// <summary>
        /// 群组id列表，创建群组时对应的一个群组id
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }
    }
}
