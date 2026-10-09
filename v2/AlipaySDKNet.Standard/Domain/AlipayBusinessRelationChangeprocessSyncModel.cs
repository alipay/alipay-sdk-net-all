using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessRelationChangeprocessSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessRelationChangeprocessSyncModel : AopObject
    {
        /// <summary>
        /// 商业关系组织id 由组织信息创建接口返回或bd分配
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 商业关系组织子类型 定向参数 需找对应BD申请
        /// </summary>
        [XmlElement("group_sub_type")]
        public string GroupSubType { get; set; }

        /// <summary>
        /// 商业关系组织类型 定向参数 需找对应BD申请
        /// </summary>
        [XmlElement("group_type")]
        public string GroupType { get; set; }

        /// <summary>
        /// 异动数据处理状态 PROCESSED-已处理
        /// </summary>
        [XmlElement("process_status")]
        public string ProcessStatus { get; set; }

        /// <summary>
        /// 处理目标门店id，填real_shop_id
        /// </summary>
        [XmlElement("process_target_id")]
        public string ProcessTargetId { get; set; }

        /// <summary>
        /// 处理目标类型，默认SHOP
        /// </summary>
        [XmlElement("process_target_type")]
        public string ProcessTargetType { get; set; }
    }
}
