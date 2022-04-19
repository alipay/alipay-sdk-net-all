using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtLinktypeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtLinktypeQueryModel : AopObject
    {
        /// <summary>
        /// 关联场景类型code
        /// </summary>
        [XmlElement("scene_type_code")]
        public string SceneTypeCode { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
