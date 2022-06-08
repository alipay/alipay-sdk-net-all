using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpLixinUserfillformQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpLixinUserfillformQueryModel : AopObject
    {
        /// <summary>
        /// 企业信用立信平台问卷的问卷ID
        /// </summary>
        [XmlElement("form_id")]
        public long FormId { get; set; }

        /// <summary>
        /// 分页请求的页码，从1开始
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页请求单页内数据个数，取值范围1-100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
