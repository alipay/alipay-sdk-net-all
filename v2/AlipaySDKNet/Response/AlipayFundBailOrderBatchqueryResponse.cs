using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundBailOrderBatchqueryResponse.
    /// </summary>
    public class AlipayFundBailOrderBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 入参uid下查询到的保证金主单列表
        /// </summary>
        [XmlArray("bail_auth_list")]
        [XmlArrayItem("bail_auth_order_d_t_o")]
        public List<BailAuthOrderDTO> BailAuthList { get; set; }

        /// <summary>
        /// 入参uid下查询到的标准保证金（商城保证金/老消保保证金）列表
        /// </summary>
        [XmlArray("standard_bail_list")]
        [XmlArrayItem("standard_bail_d_t_o")]
        public List<StandardBailDTO> StandardBailList { get; set; }
    }
}
