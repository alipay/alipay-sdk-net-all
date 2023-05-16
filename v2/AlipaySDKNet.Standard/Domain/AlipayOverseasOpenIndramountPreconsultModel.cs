using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenIndramountPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenIndramountPreconsultModel : AopObject
    {
        /// <summary>
        /// 原金额
        /// </summary>
        [XmlElement("original_amount")]
        public IndrMoneyDTO OriginalAmount { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
