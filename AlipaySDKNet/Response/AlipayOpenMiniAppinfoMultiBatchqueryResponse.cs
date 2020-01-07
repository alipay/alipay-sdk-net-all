using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAppinfoMultiBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAppinfoMultiBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 多端应用信息
        /// </summary>
        [XmlArray("app_base_info_list")]
        [XmlArrayItem("multi_app_base_info_dto")]
        public List<MultiAppBaseInfoDto> AppBaseInfoList { get; set; }
    }
}
