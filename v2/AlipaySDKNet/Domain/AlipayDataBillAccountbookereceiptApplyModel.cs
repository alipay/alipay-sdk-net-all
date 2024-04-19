using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataBillAccountbookereceiptApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillAccountbookereceiptApplyModel : AopObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 明细凭证，传入流水号（转账接口查询结果）。汇总凭证，传入起止时间，格式yyyy-MM-dd_yyyy-MM-dd。
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 子账本号，或者子账本名称。模糊查询
        /// </summary>
        [XmlElement("store_no")]
        public string StoreNo { get; set; }

        /// <summary>
        /// 申请的类型。可传入：FUND_PLATFORM_DETAIL - 资金明细证明，FUND_PLATFORM_SUM - 资金汇总证明
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
