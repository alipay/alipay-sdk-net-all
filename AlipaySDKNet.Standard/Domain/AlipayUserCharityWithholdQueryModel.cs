using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCharityWithholdQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCharityWithholdQueryModel : AopObject
    {
        /// <summary>
        /// 业务场景，由爱心捐赠系统配置及分配
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 用户userId对应的openId
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
        /// 交易用户的ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("withhold_pid")]
        public string WithholdPid { get; set; }
    }
}
