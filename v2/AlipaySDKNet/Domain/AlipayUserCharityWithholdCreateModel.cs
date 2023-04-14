using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCharityWithholdCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCharityWithholdCreateModel : AopObject
    {
        /// <summary>
        /// 业务场景，由爱心捐赠系统配置及分配
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 扣款金额，单位为分
        /// </summary>
        [XmlElement("donate_amount")]
        public long DonateAmount { get; set; }

        /// <summary>
        /// 扩展信息，json格式字符串
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 交易用户的user_id对应的open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码，由爱心捐赠系统配置及分配
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 交易用户的ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 需要签约协议的用户PID
        /// </summary>
        [XmlElement("withhold_pid")]
        public string WithholdPid { get; set; }
    }
}
