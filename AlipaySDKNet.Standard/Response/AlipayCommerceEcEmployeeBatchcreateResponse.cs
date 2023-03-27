using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEmployeeBatchcreateResponse.
    /// </summary>
    public class AlipayCommerceEcEmployeeBatchcreateResponse : AopResponse
    {
        /// <summary>
        /// 添加失败员工，如果没有添加失败员工，则不返回该字段
        /// </summary>
        [XmlArray("employee_add_fail_list")]
        [XmlArrayItem("ec_employee_batch_add_fail_info")]
        public List<EcEmployeeBatchAddFailInfo> EmployeeAddFailList { get; set; }

        /// <summary>
        /// 添加成功员工，如果没有添加成功员工，则不返回该字段
        /// </summary>
        [XmlArray("employee_add_success_list")]
        [XmlArrayItem("ec_employee_batch_add_success_info")]
        public List<EcEmployeeBatchAddSuccessInfo> EmployeeAddSuccessList { get; set; }

        /// <summary>
        /// 资金代付签约链接 1.员工未绑支付宝，拉起员工绑定页面 2.员工已绑支付宝，拉起资金签约页面
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
