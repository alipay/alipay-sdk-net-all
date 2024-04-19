using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainWfRepaymentdetailQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainWfRepaymentdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("pageindex")]
        public long Pageindex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("pagesize")]
        public long Pagesize { get; set; }

        /// <summary>
        /// 还款明细
        /// </summary>
        [XmlArray("repayrecord")]
        [XmlArrayItem("repay_record_v_o")]
        public List<RepayRecordVO> Repayrecord { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("totalnums")]
        public long Totalnums { get; set; }
    }
}
