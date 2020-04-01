using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryRecord Data Structure.
    /// </summary>
    [Serializable]
    public class QueryRecord : AopObject
    {
        /// <summary>
        /// 企业编号
        /// </summary>
        [XmlElement("corp_code")]
        public string CorpCode { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("corp_name")]
        public string CorpName { get; set; }

        /// <summary>
        /// 操作人(经办人/实际签约人)姓名
        /// </summary>
        [XmlElement("opr_cert_name")]
        public string OprCertName { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// 签约顺序(0:  初始发起签约;   1：第1方签约;  2：第2方签约)
        /// </summary>
        [XmlElement("sign_order")]
        public long SignOrder { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 操作类型英文code(INIT: 发起签约;  CANCEL: 撤销签约;  APPROVE: 确认签约)
        /// </summary>
        [XmlElement("sign_type_code")]
        public string SignTypeCode { get; set; }
    }
}
