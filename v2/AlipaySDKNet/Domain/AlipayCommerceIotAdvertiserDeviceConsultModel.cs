using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserDeviceConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserDeviceConsultModel : AopObject
    {
        /// <summary>
        /// sn列表，最多100个
        /// </summary>
        [XmlArray("sn_list")]
        [XmlArrayItem("string")]
        public List<string> SnList { get; set; }
    }
}
