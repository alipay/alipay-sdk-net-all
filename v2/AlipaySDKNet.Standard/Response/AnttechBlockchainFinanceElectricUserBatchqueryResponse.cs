using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceElectricUserBatchqueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceElectricUserBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的是用电用户信息列表
        /// </summary>
        [XmlArray("electric_user_list")]
        [XmlArrayItem("energy_aggr_electric_user_info_d_t_o")]
        public List<EnergyAggrElectricUserInfoDTO> ElectricUserList { get; set; }

        /// <summary>
        /// 数据总条数，分页查询需要用到
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
