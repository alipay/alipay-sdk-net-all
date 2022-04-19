using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskTransferBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskTransferBatchqueryModel : AopObject
    {
        /// <summary>
        /// 第几页，默认1（从1开始计数）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 资金代扣签约时的出资方uid
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }

        /// <summary>
        /// 转账结束时间
        /// </summary>
        [XmlElement("trans_date_end")]
        public string TransDateEnd { get; set; }

        /// <summary>
        /// 转账开始时间
        /// </summary>
        [XmlElement("trans_date_start")]
        public string TransDateStart { get; set; }

        /// <summary>
        /// 转账类型： TRANSFER：记账本转账  WITHDRAW：记账本提现
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
