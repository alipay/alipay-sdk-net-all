using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankCrowdQueryResponse.
    /// </summary>
    public class AlipayUserDtbankCrowdQueryResponse : AopResponse
    {
        /// <summary>
        /// 人群创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 人群id
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 人群状态
        /// </summary>
        [XmlElement("crowd_status")]
        public string CrowdStatus { get; set; }

        /// <summary>
        /// 人群失效时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 归属银行机构ID
        /// </summary>
        [XmlElement("express_inst_id")]
        public string ExpressInstId { get; set; }

        /// <summary>
        /// 人群文件下载地址
        /// </summary>
        [XmlElement("file_info_url")]
        public string FileInfoUrl { get; set; }

        /// <summary>
        /// 匹配成功的支付宝账号数
        /// </summary>
        [XmlElement("match_user_total_count")]
        public long MatchUserTotalCount { get; set; }

        /// <summary>
        /// 代运营机构ID
        /// </summary>
        [XmlElement("proxy_bank_inst_id")]
        public string ProxyBankInstId { get; set; }
    }
}
