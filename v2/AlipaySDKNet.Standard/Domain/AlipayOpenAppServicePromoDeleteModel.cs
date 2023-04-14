using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServicePromoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServicePromoDeleteModel : AopObject
    {
        /// <summary>
        /// 操作类型。枚举值如下：     DELETE("DELETE", "删除"), 非审核中状态中支持该操作；     GIVE_UP_EDIT("GIVE_UP_EDIT", "放弃修改"),存在生效和编辑驳回两个版本时支持该操作;
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 服务场景素材记录ID
        /// </summary>
        [XmlElement("promo_record_id")]
        public string PromoRecordId { get; set; }
    }
}
