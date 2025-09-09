using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayInstructCloudTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayInstructCloudTriggerModel : AopObject
    {
        /// <summary>
        /// 本次收款金额，单位（元）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// ABCP请求超时时间，单位毫秒，默认值为2 * 60 * 1000L(2分钟)超时，-1表示永不超时，可以根据业务情况修改
        /// </summary>
        [XmlElement("bpaas_ipc_timeout")]
        public string BpaasIpcTimeout { get; set; }

        /// <summary>
        /// 收银类型，默认值：cashier
        /// </summary>
        [XmlElement("cashier_type")]
        public string CashierType { get; set; }

        /// <summary>
        /// 控制本次调用执行的操作： （1）show：发起收银，N设备唤起收银台 （2）pop：取消收银，N设备取消收银台 （3）update，保持收银台唤起，并更新收款金额
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 必需是cashier
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// POS 设备唯一标识，建议取 POS 设备 SN 编号，保证每个设备唯一
        /// </summary>
        [XmlElement("pos_id")]
        public string PosId { get; set; }

        /// <summary>
        /// 外部订单号 tradeNo，可确认“快捷收款”、“收银员模式”是同一个订单
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
