using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainWfBillproductableamtQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainWfBillproductableamtQueryResponse : AopResponse
    {
        /// <summary>
        /// 可贷额度列表
        /// </summary>
        [XmlArray("storeloanablelist")]
        [XmlArrayItem("mca_store_loanable_detail")]
        public List<McaStoreLoanableDetail> Storeloanablelist { get; set; }
    }
}
