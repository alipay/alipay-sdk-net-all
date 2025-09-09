using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignActionandtemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignActionandtemplateQueryModel : AopObject
    {
        /// <summary>
        /// 编辑创意场景下,所编辑创意的id
        /// </summary>
        [XmlElement("creative_id")]
        public long CreativeId { get; set; }

        /// <summary>
        /// 新增或者编辑创意所属的单元id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 创意操作类型,新增或者编辑创意
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 操作商家所属委托人标识
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
