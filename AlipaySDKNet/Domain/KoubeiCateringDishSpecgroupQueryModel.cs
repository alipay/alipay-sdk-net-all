using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishSpecgroupQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishSpecgroupQueryModel : AopObject
    {
        /// <summary>
        /// 规则标签明细的id，比如「特别热」的字典id，当传入时，也做为查询参数
        /// </summary>
        [XmlElement("detail_spec_id")]
        public string DetailSpecId { get; set; }

        /// <summary>
        /// 规格组的id，当传入时，也做为查询条件，只查询当前规格组下的明细
        /// </summary>
        [XmlElement("group_spec_id")]
        public string GroupSpecId { get; set; }
    }
}
