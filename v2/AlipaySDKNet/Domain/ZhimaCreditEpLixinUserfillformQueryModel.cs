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
        /// 表单提交结束时间，与表单开始时间组合前开后闭[start_time,end_time)
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 企业信用立信平台问卷的问卷ID
        /// </summary>
        [XmlElement("form_id")]
        public long FormId { get; set; }

        /// <summary>
        /// 支付宝用户openId列表
        /// </summary>
        [XmlArray("open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OpenIdList { get; set; }

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
        /// 表单提交开始时间，与表单结束时间组合前开后闭[start_time,end_time)
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
