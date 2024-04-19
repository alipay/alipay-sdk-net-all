using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserAdModifyModel : AopObject
    {
        /// <summary>
        /// 下线SN列表
        /// </summary>
        [XmlArray("delete_sn_list")]
        [XmlArrayItem("string")]
        public List<string> DeleteSnList { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
