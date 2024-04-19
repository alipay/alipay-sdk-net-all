using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsassetprodPetprofileDeleteResponse.
    /// </summary>
    public class AlipayInsSceneInsassetprodPetprofileDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除档案结果
        /// </summary>
        [XmlElement("delete_flag")]
        public bool DeleteFlag { get; set; }
    }
}
