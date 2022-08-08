using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectAuthorderQuerystatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectAuthorderQuerystatusModel : AopObject
    {
        /// <summary>
        /// 商家认证申请单号，参数二选一
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务号，参数二选一，业务自定义，保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
