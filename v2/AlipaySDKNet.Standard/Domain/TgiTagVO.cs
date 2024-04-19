using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TgiTagVO Data Structure.
    /// </summary>
    [Serializable]
    public class TgiTagVO : AopObject
    {
        /// <summary>
        /// 显著性特征推荐
        /// </summary>
        [XmlArray("tgi_name_list")]
        [XmlArrayItem("string")]
        public List<string> TgiNameList { get; set; }
    }
}
