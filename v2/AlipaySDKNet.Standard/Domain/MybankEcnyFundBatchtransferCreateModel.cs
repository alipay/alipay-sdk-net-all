using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyFundBatchtransferCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyFundBatchtransferCreateModel : AopObject
    {
        /// <summary>
        /// 不可使用特殊字符，如 /，=，& ，<，>等
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 由双方约定分配值
        /// </summary>
        [XmlElement("out_request_from")]
        public string OutRequestFrom { get; set; }

        /// <summary>
        /// 仅支持字母、数字，作为幂等字段，需保证在调用方内部不重复
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 付款钱包实名信息姓名
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 数字人民币钱包编号
        /// </summary>
        [XmlElement("payer_wallet_id")]
        public string PayerWalletId { get; set; }

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
        [XmlArray("transfer_detail_list")]
        [XmlArrayItem("transfer_detail")]
        public List<TransferDetail> TransferDetailList { get; set; }

        /// <summary>
        /// 不可使用特殊字符，如 /，=，& ，<，>等
        /// </summary>
        [XmlElement("transfer_purpose")]
        public string TransferPurpose { get; set; }
    }
}
