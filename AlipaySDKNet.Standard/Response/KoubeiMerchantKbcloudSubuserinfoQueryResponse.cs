using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserinfoQueryResponse.
    /// </summary>
    public class KoubeiMerchantKbcloudSubuserinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 口碑子账号数据列表
        /// </summary>
        [XmlArray("sub_cloud_user_list")]
        [XmlArrayItem("sub_cloud_user_info")]
        public List<SubCloudUserInfo> SubCloudUserList { get; set; }
    }
}
