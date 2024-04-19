using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishCommGroupInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishCommGroupInfo : AopObject
    {
        /// <summary>
        /// 通用组id 口碑生成；新增时非必填
        /// </summary>
        [XmlElement("comm_group_id")]
        public string CommGroupId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 扩展字段，用户扩展字段的透出填写，不做约束
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 组描述
        /// </summary>
        [XmlElement("group_desc")]
        public string GroupDesc { get; set; }

        /// <summary>
        /// 组的名称，标示一个组的中文，可重复
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// materialGroup 加料组 propertyGroup 属性组
        /// </summary>
        [XmlElement("group_type")]
        public string GroupType { get; set; }

        /// <summary>
        /// 组明细列表
        /// </summary>
        [XmlArray("kbdish_comm_group_detail_info_list")]
        [XmlArrayItem("kbdish_comm_group_detail_info")]
        public List<KbdishCommGroupDetailInfo> KbdishCommGroupDetailInfoList { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }

        /// <summary>
        /// 组在口碑C端展示的样式，枚举如下： list：明细以列表展示 select：每行展示3个明细；对于加料，选中明细时，份数默认为1份，不能调整 selectWithAdjust：每行展示3个明细；对于加料选中明细时，在份数区块可以进行份数调整 listWithCheckBox：明细以列表的方式展示，带有勾选框
        /// </summary>
        [XmlElement("view_tag")]
        public string ViewTag { get; set; }
    }
}
