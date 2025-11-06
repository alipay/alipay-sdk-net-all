using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIssalaryPayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIssalaryPayQueryModel : AopObject
    {
        /// <summary>
        /// 小二薪酬编号列表, user_bill_no的列表
        /// </summary>
        [XmlArray("user_bill_no_list")]
        [XmlArrayItem("string")]
        public List<string> UserBillNoList { get; set; }
    }
}
