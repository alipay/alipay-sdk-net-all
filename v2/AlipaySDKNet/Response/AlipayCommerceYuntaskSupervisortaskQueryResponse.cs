using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskSupervisortaskQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskSupervisortaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务实例信息
        /// </summary>
        [XmlElement("task_instance_info")]
        public SupervisorTaskInstanceDTO TaskInstanceInfo { get; set; }

        /// <summary>
        /// 未到访门店列表
        /// </summary>
        [XmlArray("unvisit_shop_list")]
        [XmlArrayItem("visit_shop_d_t_o")]
        public List<VisitShopDTO> UnvisitShopList { get; set; }

        /// <summary>
        /// 已到访门店列表
        /// </summary>
        [XmlArray("visit_shop_list")]
        [XmlArrayItem("visit_shop_d_t_o")]
        public List<VisitShopDTO> VisitShopList { get; set; }
    }
}
