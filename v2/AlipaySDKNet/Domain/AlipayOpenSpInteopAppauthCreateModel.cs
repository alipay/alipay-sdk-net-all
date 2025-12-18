using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpInteopAppauthCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpInteopAppauthCreateModel : AopObject
    {
        /// <summary>
        /// 业务开通主单号
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }

        /// <summary>
        /// 申请授权的三方应用appid
        /// </summary>
        [XmlElement("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 代调用授权成功之后会在授权通知里携带此值
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
