using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandScodeEledeSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandScodeEledeSignModel : AopObject
    {
        /// <summary>
        /// 打标请求参数
        /// </summary>
        [XmlArray("add_tag_request")]
        [XmlArrayItem("add_tag_request")]
        public List<AddTagRequest> AddTagRequest { get; set; }
    }
}
