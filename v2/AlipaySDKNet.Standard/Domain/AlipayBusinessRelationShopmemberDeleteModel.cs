using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessRelationShopmemberDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessRelationShopmemberDeleteModel : AopObject
    {
        /// <summary>
        /// 商业关系组织id 由组织信息创建接口返回或bd分配或业务标识id，如mallid
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
        /// 商业关系物理门店资产成员编号
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }
    }
}
