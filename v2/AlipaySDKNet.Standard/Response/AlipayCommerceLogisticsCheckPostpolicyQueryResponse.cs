using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsCheckPostpolicyQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsCheckPostpolicyQueryResponse : AopResponse
    {
        /// <summary>
        /// 合法的小程序验收结果
        /// </summary>
        [XmlArray("app_check_info_list")]
        [XmlArrayItem("ecocheck_yz_policy_check_detail")]
        public List<EcocheckYzPolicyCheckDetail> AppCheckInfoList { get; set; }

        /// <summary>
        /// 无效或无权限查询的appId列表
        /// </summary>
        [XmlArray("invalid_app_id_list")]
        [XmlArrayItem("string")]
        public List<string> InvalidAppIdList { get; set; }
    }
}
