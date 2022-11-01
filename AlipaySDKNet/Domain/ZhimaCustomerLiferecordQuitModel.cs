using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerLiferecordQuitModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerLiferecordQuitModel : AopObject
    {
        /// <summary>
        /// 操作枚举
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号列表
        /// </summary>
        [XmlArray("out_biz_nos")]
        [XmlArrayItem("string")]
        public List<string> OutBizNos { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
