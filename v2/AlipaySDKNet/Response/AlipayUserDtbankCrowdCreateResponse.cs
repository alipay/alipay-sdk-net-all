using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankCrowdCreateResponse.
    /// </summary>
    public class AlipayUserDtbankCrowdCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 人群状态
        /// </summary>
        [XmlElement("crowd_status")]
        public string CrowdStatus { get; set; }

        /// <summary>
        /// 归属银行机构ID
        /// </summary>
        [XmlElement("express_inst_id")]
        public string ExpressInstId { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 代运营方机构ID
        /// </summary>
        [XmlElement("proxy_bank_inst_id")]
        public string ProxyBankInstId { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlElement("user_info")]
        public string UserInfo { get; set; }
    }
}
