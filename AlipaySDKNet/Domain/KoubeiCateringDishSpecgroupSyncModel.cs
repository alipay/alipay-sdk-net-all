using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishSpecgroupSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishSpecgroupSyncModel : AopObject
    {
        /// <summary>
        /// 创建者
        /// </summary>
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 规格标签
        /// </summary>
        [XmlElement("kbdish_spec_group")]
        public KbdishSpecGroup KbdishSpecGroup { get; set; }

        /// <summary>
        /// 同步类型: add 新增,del 删除,update 更新
        /// </summary>
        [XmlElement("syn_type")]
        public string SynType { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
