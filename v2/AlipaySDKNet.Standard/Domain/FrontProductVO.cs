using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FrontProductVO Data Structure.
    /// </summary>
    [Serializable]
    public class FrontProductVO : AopObject
    {
        /// <summary>
        /// 产品包含的权限集列表
        /// </summary>
        [XmlArray("permission_set_list")]
        [XmlArrayItem("permission_set_v_o")]
        public List<PermissionSetVO> PermissionSetList { get; set; }

        /// <summary>
        /// 服务商代运营基础包
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 服务商代运营基础包
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }
    }
}
