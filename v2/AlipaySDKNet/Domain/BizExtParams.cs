using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizExtParams Data Structure.
    /// </summary>
    [Serializable]
    public class BizExtParams : AopObject
    {
        /// <summary>
        /// 拼团场景下，所有参团人userid列表
        /// </summary>
        [XmlArray("groupon_partners")]
        [XmlArrayItem("string")]
        public List<string> GrouponPartners { get; set; }
    }
}
