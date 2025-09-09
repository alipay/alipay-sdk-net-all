using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepDossierBackgroundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepDossierBackgroundInfo : AopObject
    {
        /// <summary>
        /// 企业背景标签
        /// </summary>
        [XmlArray("label")]
        [XmlArrayItem("string")]
        public List<string> Label { get; set; }
    }
}
