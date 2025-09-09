using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenAssetPublishConsultResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenAssetPublishConsultResult : AopObject
    {
        /// <summary>
        /// 资产id，券id、模板id等
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 返回券id+业务场景+品类+省份的组合信息
        /// </summary>
        [XmlElement("asset_info")]
        public string AssetInfo { get; set; }

        /// <summary>
        /// 实体id，配合实体id类型使用，可以是类目id、券id、模板id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 发放咨询是否通过
        /// </summary>
        [XmlElement("passed")]
        public bool Passed { get; set; }

        /// <summary>
        /// 未申领UN_PUBLISH已申领PUBLISHED已核销USED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
