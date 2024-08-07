using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupgiftStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupgiftStatusModifyModel : AopObject
    {
        /// <summary>
        /// 渠道code
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 群组id，表里唯一键，创建群组自动生成
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 入群有礼更新状态，对指定群组、指定渠道更新状态 。操作说明：1、状态valid生效中时，只能进行invalid停用 或 delete删除操作2、状态suspend已暂停时，只能进行valid启用 或 delete删除操作。3、所有状态都支持delete删除操作。 状态流转如下： valid(生效状态) -> suspend(已暂停状态)；valid(生效中状态) -> delete(删除状态)； suspend(已暂停状态) -> valid(生效状态)； suspend(已暂停状态) -> delete(删除状态)；init(未生效状态) -> delete(删除状态)；invalid(已失效状态) -> delete(删除状态)；expire(已过期状态) -> delete(删除状态)。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
