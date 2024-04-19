using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishCommgroupSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishCommgroupSyncModel : AopObject
    {
        /// <summary>
        /// group：组信息；detail：明细信息
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 组模型
        /// </summary>
        [XmlElement("kbdish_comm_group_info")]
        public KbdishCommGroupInfo KbdishCommGroupInfo { get; set; }

        /// <summary>
        /// 同步类型: add 新增;update 修改;del 删除
        /// </summary>
        [XmlElement("syn_type")]
        public string SynType { get; set; }
    }
}
