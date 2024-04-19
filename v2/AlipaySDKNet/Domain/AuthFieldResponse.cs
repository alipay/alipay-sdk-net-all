using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthFieldResponse Data Structure.
    /// </summary>
    [Serializable]
    public class AuthFieldResponse : AopObject
    {
        /// <summary>
        /// 用户信息申请记录列表
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("auth_field_d_t_o")]
        public List<AuthFieldDTO> Records { get; set; }
    }
}
