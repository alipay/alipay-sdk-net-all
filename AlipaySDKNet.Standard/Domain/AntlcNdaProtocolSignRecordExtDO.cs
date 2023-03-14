using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntlcNdaProtocolSignRecordExtDO Data Structure.
    /// </summary>
    [Serializable]
    public class AntlcNdaProtocolSignRecordExtDO : AopObject
    {
        /// <summary>
        /// 上链存证实例ID
        /// </summary>
        [XmlElement("antlc_certificate_key")]
        public string AntlcCertificateKey { get; set; }

        /// <summary>
        /// 是否可催签，true：是；false：否
        /// </summary>
        [XmlElement("expedite_status")]
        public bool ExpediteStatus { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 协议实例id
        /// </summary>
        [XmlElement("instl_id")]
        public long InstlId { get; set; }

        /// <summary>
        /// 最后一次催签时间
        /// </summary>
        [XmlElement("last_expedite_time")]
        public string LastExpediteTime { get; set; }

        /// <summary>
        /// 签约模式，FACE：人脸识别；PASS：直接通过；SIGN：手绘签名
        /// </summary>
        [XmlElement("sign_mode")]
        public string SignMode { get; set; }

        /// <summary>
        /// 签约状态:SIGNED：已签约；SENT：未签约；FAILED：初始化失败；INIT：初始化中;SIGNING:签约中
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 签约人2088账号
        /// </summary>
        [XmlElement("signator_2088")]
        public string Signator2088 { get; set; }

        /// <summary>
        /// 协议签约人公司钉钉id
        /// </summary>
        [XmlElement("signator_corp_id")]
        public string SignatorCorpId { get; set; }

        /// <summary>
        /// 协议签约员工工号
        /// </summary>
        [XmlElement("signator_staff_id")]
        public string SignatorStaffId { get; set; }

        /// <summary>
        /// 协议签约员工名称
        /// </summary>
        [XmlElement("signator_staff_name")]
        public string SignatorStaffName { get; set; }

        /// <summary>
        /// 协议签约人员unionId
        /// </summary>
        [XmlElement("signator_staff_union_id")]
        public string SignatorStaffUnionId { get; set; }

        /// <summary>
        /// 协议存放地址
        /// </summary>
        [XmlElement("signed_file_addr")]
        public string SignedFileAddr { get; set; }

        /// <summary>
        /// 本次上链区块交易哈希
        /// </summary>
        [XmlElement("tx_hash_code")]
        public string TxHashCode { get; set; }
    }
}
