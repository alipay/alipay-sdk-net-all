using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SlowLog Data Structure.
    /// </summary>
    [Serializable]
    public class SlowLog : AopObject
    {
        /// <summary>
        /// 客户端IP
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 数据库集合名称
        /// </summary>
        [XmlElement("collection_name")]
        public string CollectionName { get; set; }

        /// <summary>
        /// 耗时(毫秒)
        /// </summary>
        [XmlElement("cost")]
        public long Cost { get; set; }

        /// <summary>
        /// 执行时间
        /// </summary>
        [XmlElement("execute_time")]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 云函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// mongoDB的社区版的原生语法，key代表字段或者关键字，value代表值:例如    {      $addFields: {        totalHomework: { $sum: "$homework" } ,        totalQuiz: { $sum: "$quiz" }      }    }
        /// </summary>
        [XmlElement("request_body")]
        public string RequestBody { get; set; }

        /// <summary>
        /// 执行结果返回行数
        /// </summary>
        [XmlElement("row_count")]
        public string RowCount { get; set; }
    }
}
