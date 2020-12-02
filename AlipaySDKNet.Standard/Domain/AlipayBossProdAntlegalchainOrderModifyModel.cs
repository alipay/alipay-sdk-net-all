using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlegalchainOrderModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlegalchainOrderModifyModel : AopObject
    {
        /// <summary>
        /// 发起签约接口返回的baseDataId
        /// </summary>
        [XmlElement("bas_data_id")]
        public string BasDataId { get; set; }

        /// <summary>
        /// 业务数据请求唯一标识，需要保证唯一性
        /// </summary>
        [XmlElement("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 公司名称和公司社会信用编码二者必传
        /// </summary>
        [XmlElement("corp_code")]
        public string CorpCode { get; set; }

        /// <summary>
        /// 公司名称和公司社会信用编码二者必传
        /// </summary>
        [XmlElement("corp_name")]
        public string CorpName { get; set; }

        /// <summary>
        /// 操作人邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 签约操作原因，撤回签约操作建议传参
        /// </summary>
        [XmlElement("op_reason")]
        public string OpReason { get; set; }

        /// <summary>
        /// 签约操作类型 (CANCEL: 撤回签约；APPROVE: 确认签约)
        /// </summary>
        [XmlElement("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 请求来源系统英文名称
        /// </summary>
        [XmlElement("request_app_name")]
        public string RequestAppName { get; set; }

        /// <summary>
        /// 请求时间戳（请求时间的毫秒值）
        /// </summary>
        [XmlElement("request_time_stamp")]
        public string RequestTimeStamp { get; set; }

        /// <summary>
        /// 请求token
        /// </summary>
        [XmlElement("request_token")]
        public string RequestToken { get; set; }

        /// <summary>
        /// 阿里账号统一ID，特殊需求时使用
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
