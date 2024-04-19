using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanTuringtagQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanTuringtagQueryModel : AopObject
    {
        /// <summary>
        /// 节点编码列表
        /// </summary>
        [XmlArray("node_code_list")]
        [XmlArrayItem("string")]
        public List<string> NodeCodeList { get; set; }
    }
}
