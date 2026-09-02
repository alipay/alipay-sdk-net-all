using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RemoteExternalBillDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RemoteExternalBillDetail : AopObject
    {
        /// <summary>
        /// 账期描述
        /// </summary>
        [XmlElement("bill_date_desc")]
        public string BillDateDesc { get; set; }

        /// <summary>
        /// 账期结束时间
        /// </summary>
        [XmlElement("bill_date_end")]
        public string BillDateEnd { get; set; }

        /// <summary>
        /// 账期起始时间
        /// </summary>
        [XmlElement("bill_date_start")]
        public string BillDateStart { get; set; }

        /// <summary>
        /// 账单滞纳金产生时间
        /// </summary>
        [XmlElement("fine_date")]
        public string FineDate { get; set; }

        /// <summary>
        /// 20200927111102020200122000000000
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 账单备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 出账日期
        /// </summary>
        [XmlElement("release_date")]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// 账单排序
        /// </summary>
        [XmlElement("sequence")]
        public long Sequence { get; set; }

        /// <summary>
        /// 账单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 账单总金额,单位 元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
