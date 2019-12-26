using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantKbcloudClouduserinfoQueryResponse.
    /// </summary>
    public class KoubeiMerchantKbcloudClouduserinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 口碑云主账号数据列表
        /// </summary>
        [XmlArray("cloud_user_list")]
        [XmlArrayItem("cloud_user_info")]
        public List<CloudUserInfo> CloudUserList { get; set; }
    }
}
