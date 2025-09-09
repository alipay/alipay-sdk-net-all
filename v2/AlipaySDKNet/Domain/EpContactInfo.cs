using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpContactInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpContactInfo : AopObject
    {
        /// <summary>
        /// 企业社会公开的联系方式列表
        /// </summary>
        [XmlArray("ep_contact")]
        [XmlArrayItem("string")]
        public List<string> EpContact { get; set; }
    }
}
