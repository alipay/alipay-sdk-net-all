using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyFundBatchtransferQueryResponse.
    /// </summary>
    public class MybankEcnyFundBatchtransferQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单受理失败时，失败原因必填。
        /// </summary>
        [XmlElement("batch_transfer_fail_reason")]
        public string BatchTransferFailReason { get; set; }

        /// <summary>
        /// 交易完成时间
        /// </summary>
        [XmlElement("gmt_success")]
        public string GmtSuccess { get; set; }

        /// <summary>
        /// 网商银行订单号，处理完成时必填
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 由双方协商约定分配值
        /// </summary>
        [XmlElement("out_request_from")]
        public string OutRequestFrom { get; set; }

        /// <summary>
        /// 仅支持字母、数字，作为幂等字段，需保证在调用方内部不重复
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 批量代发单处理状态，枚举值：ACCEPTING-受理中，FINISH-处理完成，ACCEPT_FAIL-受理失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("success_amount")]
        public string SuccessAmount { get; set; }

        /// <summary>
        /// 代发成功总笔数
        /// </summary>
        [XmlElement("success_num")]
        public long SuccessNum { get; set; }

        /// <summary>
        /// 单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 代发总笔数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("transfer_info_list")]
        [XmlArrayItem("ecny_batch_transfer_info")]
        public List<EcnyBatchTransferInfo> TransferInfoList { get; set; }
    }
}
