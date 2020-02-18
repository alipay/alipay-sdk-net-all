using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskAntifraudBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityRiskAntifraudBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 供应商关系列表+company_list是两个有关系的供应商，detail字段描述了具体的关系，detail为jsonArray表示两者之间可能的多种关系
        /// </summary>
        [XmlArray("company_relation_list")]
        [XmlArrayItem("string")]
        public List<string> CompanyRelationList { get; set; }

        /// <summary>
        /// 员工供应商关系列表+staff字段为员工姓名，company字段为供应商，detail描述了员工和供应商的关系详情,detail为jsonArray表示两者之间可能的多种关系
        /// </summary>
        [XmlArray("staff_company_relation_list")]
        [XmlArrayItem("string")]
        public List<string> StaffCompanyRelationList { get; set; }
    }
}
