using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupPromotechannelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupPromotechannelCreateModel : AopObject
    {
        /// <summary>
        /// 渠道描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 群组id，表里唯一键，创建群组自动生成，编辑群组必填
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 渠道参数（英文名称），仅支持数字字母和下划线
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 渠道父节点id，若是一级渠道不需要传值
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }
    }
}
