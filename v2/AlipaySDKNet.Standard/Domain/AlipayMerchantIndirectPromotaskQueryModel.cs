using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectPromotaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectPromotaskQueryModel : AopObject
    {
        /// <summary>
        /// 平台定义的业务场景编码，用以区分不同的业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 支付宝侧定义的商户组编号，作为同一商户主体下多个smid的唯一商户编号
        /// </summary>
        [XmlElement("group_mid")]
        public string GroupMid { get; set; }

        /// <summary>
        /// 任务标识编码，用以区分任务类型
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// 商家报名任务通过后生成的唯一任务编号
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
