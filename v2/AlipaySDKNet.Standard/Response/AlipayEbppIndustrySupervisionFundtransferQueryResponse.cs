using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionFundtransferQueryResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionFundtransferQueryResponse : AopResponse
    {
        /// <summary>
        /// 冻资关联账户
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 划拨金额（整数，单位：分）
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
        /// 行业受理操作单号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 资金划拨时对手方账户
        /// </summary>
        [XmlElement("opposite_account_no")]
        public string OppositeAccountNo { get; set; }

        /// <summary>
        /// 外部请求流水号
        /// </summary>
        [XmlElement("out_flow_id")]
        public string OutFlowId { get; set; }

        /// <summary>
        /// 资金划拨场景
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
