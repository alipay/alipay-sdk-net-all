using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsPetOrgprofileCreateResponse.
    /// </summary>
    public class AlipayInsPetOrgprofileCreateResponse : AopResponse
    {
        /// <summary>
        /// 宠物档案唯一标识
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }
    }
}
