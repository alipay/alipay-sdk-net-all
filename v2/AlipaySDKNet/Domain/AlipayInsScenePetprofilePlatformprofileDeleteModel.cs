using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePetprofilePlatformprofileDeleteModel : AopObject
    {
        /// <summary>
        /// 创建档案后，生成的档案唯一标记
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }
    }
}
