using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class QueryInfo : AopObject
    {
        /// <summary>
        /// 调用系统的appName
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 调用者域账号,与使用者工号二选一
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 调用类型+REAL_TIME(时调用，推荐)/SCHEDULE(定时任务同步)
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 使用者工号,为空可传 -1 或者不传
        /// </summary>
        [XmlElement("user_no")]
        public string UserNo { get; set; }
    }
}
