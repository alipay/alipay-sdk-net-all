using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndirectExtraCredentials Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectExtraCredentials : AopObject
    {
        /// <summary>
        /// 待确认商户号列表，最多20个
        /// </summary>
        [XmlArray("smid_list")]
        [XmlArrayItem("string")]
        public List<string> SmidList { get; set; }
    }
}
