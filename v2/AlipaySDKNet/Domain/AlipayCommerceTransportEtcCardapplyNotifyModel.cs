using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcCardapplyNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcCardapplyNotifyModel : AopObject
    {
        /// <summary>
        /// 银行侧开卡回传状态。注意对同一个开卡申请单每个阶段的状态不可被相互覆盖。例如：申请提交成功了，不再接受申请提交失败；申请提交失败了也不再接受申请提交成功。
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 业务状态变更发生的时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 对部分状态值的额外描述，例如：回传申请提交失败状态时，可以通过这个字段传入失败原因（已持卡客户，重复提交客户，其他）
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// order_id是支付宝侧生成，在开卡申请的时候作为业务方流水号传给银行，银行侧需要记下这个order_id，在开卡申请状态变更这个接口中回传
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号，在该接口中为银行侧生成的申请流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
