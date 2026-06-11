using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDoctorgwHomecacheDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDoctorgwHomecacheDeleteModel : AopObject
    {
        /// <summary>
        /// 是否删除全部模块缓存
        /// </summary>
        [XmlElement("delete_all")]
        public bool DeleteAll { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("module_codes")]
        [XmlArrayItem("string")]
        public List<string> ModuleCodes { get; set; }

        /// <summary>
        /// 外部业务唯一id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务唯一id
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 外部用户类型
        /// </summary>
        [XmlElement("out_user_type")]
        public string OutUserType { get; set; }
    }
}
