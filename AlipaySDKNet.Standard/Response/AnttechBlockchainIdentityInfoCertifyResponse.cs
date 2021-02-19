using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainIdentityInfoCertifyResponse.
    /// </summary>
    public class AnttechBlockchainIdentityInfoCertifyResponse : AopResponse
    {
        /// <summary>
        /// 账户ID
        /// </summary>
        [XmlElement("acc_id")]
        public string AccId { get; set; }

        /// <summary>
        /// 错误码code，0代表成功， 非0不成功
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 业务账户DID
        /// </summary>
        [XmlElement("did")]
        public string Did { get; set; }

        /// <summary>
        /// 表示是否成功，paas=true 表示业务验证通过，需要和success 共同判断业务是否成功
        /// </summary>
        [XmlElement("pass")]
        public bool Pass { get; set; }

        /// <summary>
        /// 业务系统ID
        /// </summary>
        [XmlElement("req_msg_id")]
        public string ReqMsgId { get; set; }

        /// <summary>
        /// 代表业务成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }

        /// <summary>
        /// 代表业务成功，其他字段代表具体的错误
        /// </summary>
        [XmlElement("sys_err_code")]
        public string SysErrCode { get; set; }

        /// <summary>
        /// 具体的错误美容描述
        /// </summary>
        [XmlElement("sys_err_msg")]
        public string SysErrMsg { get; set; }
    }
}
