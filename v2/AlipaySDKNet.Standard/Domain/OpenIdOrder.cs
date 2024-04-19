using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenIdOrder Data Structure.
    /// </summary>
    [Serializable]
    public class OpenIdOrder : AopObject
    {
        /// <summary>
        /// 工单唯一标识
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// INIT：初始状态，此状态下上传用户ID，最后提交 AUDIT：审核中 REFUSE：已驳回，原因请查看refuse_reason RUNNING：数据转换中 CANCEL：已取消 FINISH：完成，此状态可查询openid
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 审核人员填写的驳回原因
        /// </summary>
        [XmlElement("refuse_reason")]
        public string RefuseReason { get; set; }
    }
}
