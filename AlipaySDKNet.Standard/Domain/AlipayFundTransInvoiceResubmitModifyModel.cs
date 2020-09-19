using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransInvoiceResubmitModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransInvoiceResubmitModifyModel : AopObject
    {
        /// <summary>
        /// 业务ID
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 是否是区块链数据 1 是区块链 0 非区块链
        /// </summary>
        [XmlElement("is_block")]
        public string IsBlock { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        [XmlElement("uid_range")]
        public string UidRange { get; set; }
    }
}
