using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntfarmOrnamentresourceBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntfarmOrnamentresourceBatchqueryModel : AopObject
    {
        /// <summary>
        /// 装扮资源key
        /// </summary>
        [XmlArray("ornament_resource_key_list")]
        [XmlArrayItem("string")]
        public List<string> OrnamentResourceKeyList { get; set; }
    }
}
