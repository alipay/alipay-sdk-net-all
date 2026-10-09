using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtScenetypeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtScenetypeQueryModel : AopObject
    {
        /// <summary>
        /// 是否仅查询生效状态，默认true
        /// </summary>
        [XmlElement("only_pass")]
        public bool OnlyPass { get; set; }

        /// <summary>
        /// 创建人域名，可为空。仅需要查询全部状态类目时指定，若queryAll参数为true则忽略该参数；否则查询结果为：所有生效状态 + 非生效状态且creator = operator 的类目
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 是否查询所有节点(含非生效)，仅需要查询全部状态类目时指定，若该参数为true则忽略operator参数
        /// </summary>
        [XmlElement("query_all")]
        public string QueryAll { get; set; }

        /// <summary>
        /// 租户id，必填
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
