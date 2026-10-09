using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCareerOpenbaseFollowupCreateResponse.
    /// </summary>
    public class AlipayCommerceCareerOpenbaseFollowupCreateResponse : AopResponse
    {
        /// <summary>
        /// 平台任务号(18 位纯数字,按字符串处理,勿解析内部结构);用于回告与计费对账。查询、取消以 outBizNo 定位。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 原样回传客户业务单号。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
