using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiCustomerAnalysisResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiCustomerAnalysisResult : AopObject
    {
        /// <summary>
        /// 返回全部用户类型的指标数据
        /// </summary>
        [XmlArray("all_user_data")]
        [XmlArrayItem("open_api_operation_analysis_customer_alias_d_t_o")]
        public List<OpenApiOperationAnalysisCustomerAliasDTO> AllUserData { get; set; }

        /// <summary>
        /// 返回新用户（新访客）的指标数据
        /// </summary>
        [XmlArray("new_user_data")]
        [XmlArrayItem("open_api_operation_analysis_customer_alias_d_t_o")]
        public List<OpenApiOperationAnalysisCustomerAliasDTO> NewUserData { get; set; }

        /// <summary>
        /// 用户返回老用户（老客户）的指标数据
        /// </summary>
        [XmlArray("old_user_data")]
        [XmlArrayItem("open_api_operation_analysis_customer_alias_d_t_o")]
        public List<OpenApiOperationAnalysisCustomerAliasDTO> OldUserData { get; set; }
    }
}
