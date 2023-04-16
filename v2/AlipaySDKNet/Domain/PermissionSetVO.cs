using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PermissionSetVO Data Structure.
    /// </summary>
    [Serializable]
    public class PermissionSetVO : AopObject
    {
        /// <summary>
        /// 接口列表
        /// </summary>
        [XmlArray("api_info_list")]
        [XmlArrayItem("api_info_v_o")]
        public List<ApiInfoVO> ApiInfoList { get; set; }

        /// <summary>
        /// 权限集编码
        /// </summary>
        [XmlElement("permission_code")]
        public string PermissionCode { get; set; }

        /// <summary>
        /// 服务商代运营基础
        /// </summary>
        [XmlElement("permission_name")]
        public string PermissionName { get; set; }
    }
}
