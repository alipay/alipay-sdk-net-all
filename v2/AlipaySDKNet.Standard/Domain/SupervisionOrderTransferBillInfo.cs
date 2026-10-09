using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupervisionOrderTransferBillInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SupervisionOrderTransferBillInfo : AopObject
    {
        /// <summary>
        /// 用户冻资子户号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 流水金额，整数（单位：分）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_flow_id")]
        public string OutFlowId { get; set; }

        /// <summary>
        /// 关联外部订单号
        /// </summary>
        [XmlElement("relation_out_order_no")]
        public string RelationOutOrderNo { get; set; }

        /// <summary>
        /// 当前资金操作场景
        /// </summary>
        [XmlElement("transfer_scene")]
        public string TransferScene { get; set; }

        /// <summary>
        /// 资金划拨结果
        /// </summary>
        [XmlElement("transfer_status")]
        public string TransferStatus { get; set; }

        /// <summary>
        /// 资金划拨时间
        /// </summary>
        [XmlElement("transfer_time")]
        public string TransferTime { get; set; }
    }
}
