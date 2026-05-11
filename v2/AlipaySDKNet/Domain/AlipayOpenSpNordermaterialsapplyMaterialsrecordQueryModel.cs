using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyMaterialsrecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsapplyMaterialsrecordQueryModel : AopObject
    {
        /// <summary>
        /// 铺设记录ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
