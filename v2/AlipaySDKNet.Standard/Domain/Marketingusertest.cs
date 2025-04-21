using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Marketingusertest Data Structure.
    /// </summary>
    [Serializable]
    public class Marketingusertest : AopObject
    {
        /// <summary>
        /// 这是一个测试
        /// </summary>
        [XmlArray("test_12")]
        [XmlArrayItem("transfer_address_info")]
        public List<TransferAddressInfo> Test12 { get; set; }
    }
}
