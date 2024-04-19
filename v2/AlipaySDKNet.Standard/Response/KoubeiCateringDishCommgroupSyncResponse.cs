using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishCommgroupSyncResponse.
    /// </summary>
    public class KoubeiCateringDishCommgroupSyncResponse : AopResponse
    {
        /// <summary>
        /// 通用分组的id,标示组结构的唯一id
        /// </summary>
        [XmlElement("comm_group_id")]
        public string CommGroupId { get; set; }

        /// <summary>
        /// 客制化组模型，新增和更新的时候传出
        /// </summary>
        [XmlElement("kbdish_comm_group_info")]
        public KbdishCommGroupInfo KbdishCommGroupInfo { get; set; }
    }
}
